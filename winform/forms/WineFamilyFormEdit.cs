using System;
using MaterialSkin.Controls;
using MaterialSkin;
using winform.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
namespace winform.forms
{
    public partial class WineFamilyFormEdit : MaterialForm
    {
        public WineFamilyFormEdit(WineFamily family)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            this.wineFamily = family;
            this.textBox1.Text = family.Name;
        }

        WineFamily wineFamily;
    
        static async Task<string> SendURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
                    RequestUri = u,
                    Content = c
                };

                HttpResponseMessage result = await client.SendAsync(request);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }

        private void Annuler_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private async void Envoyer_Click(object sender, EventArgs e)
        {

            var family = new WineFamily();
            var name = this.textBox1.Text;
            family.Name = name;
            family.Id = this.wineFamily.Id;
            var jsonString = System.Text.Json.JsonSerializer.Serialize(family);

            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/WineFamilies/"+ this.wineFamily.Id), content));

            this.Visible = false;
        }
    }
}
