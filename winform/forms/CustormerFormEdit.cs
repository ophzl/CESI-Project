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
    public partial class CustormerFormEdit : MaterialForm
    {
        public CustormerFormEdit(Customer cust)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            
            this.customer = cust;
            this.textBox1.Text = cust.Name;
            this.textBox2.Text = cust.Address;
        }

        Customer customer;
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

        private async void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var client = new Customer();
            var name = this.textBox1.Text;
            var addresse = this.textBox2.Text;
            client.Name = name;
            client.Address = addresse;
            client.Id = customer.Id;
            var jsonString = System.Text.Json.JsonSerializer.Serialize(client);

            
            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/Customers/" + this.customer.Id), content));

            this.Dispose(); this.Close();

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Dispose(); this.Close();
        }
    }
}
