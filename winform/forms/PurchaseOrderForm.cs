using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;
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
    public partial class PurchaseOrderForm : MaterialForm
    {
        public PurchaseOrderForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);

            try
            {
                var url = "https://localhost:5001/api/WineFamilies/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<WineFamily>>(s);
                    comboBox1.DataSource = arr;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        static async Task<string> SendURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Envoyer_Click(object sender, EventArgs e)
        {
            var product = new Product();
            var name = this.textBox1.Text;
            var price = this.textBox2.Text;
            var sellPrice = this.textBox3.Text;

            product.Name = name;
            if (this.comboBox1.SelectedValue != null)
            {
                var familyId = this.comboBox1.SelectedValue;
                var familyIdConverted = this.comboBox1.SelectedItem.ToString();
                product.WineFamily_Id = Convert.ToInt64(this.comboBox1.SelectedValue);
            }
            else
            {
                return;
            }
            if (double.TryParse(price, out var parsedPrice))
            {

                product.Price = parsedPrice;
            }
            else
            {
                return;
            }
            if (double.TryParse(sellPrice, out var parsedSellPrice))
            {
                product.SellPrice = parsedSellPrice;
            }
            else
            {
                return;
            }
            var jsonString = System.Text.Json.JsonSerializer.Serialize(product);


            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/Products"), content));

            this.Visible = false;
        }

        private void Annuler_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
