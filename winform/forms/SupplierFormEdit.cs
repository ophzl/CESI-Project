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
    public partial class SupplierFormEdit : MaterialForm
    {
        public SupplierFormEdit(Supplier sup)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            this.supplier = sup;
            this.textBox1.Text = sup.Name;
            this.textBox2.Text = sup.Address;
        }

        Supplier supplier;
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

            var newSupplier = new Supplier();
            var name = this.textBox1.Text;
            var addresse = this.textBox2.Text;
            newSupplier.Name = name;
            newSupplier.Address = addresse;
            newSupplier.Id = this.supplier.Id;
            var jsonString = System.Text.Json.JsonSerializer.Serialize(newSupplier);


            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/Suppliers/"+ this.supplier.Id), content));

            this.Visible = false;

        }
    }
}
