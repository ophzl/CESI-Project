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
            this.OrderList = new List<Order>();
            this.ProductsList = new List<Product>();

            try
            {
                var url = "https://localhost:5001/api/Suppliers/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<Supplier>>(s);
                    comboBox2.DataSource = arr;
                    comboBox2.DisplayMember = "Name";
                    comboBox2.ValueMember = "Id";
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

            try
            {
                var url = "https://localhost:5001/api/Products/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<Product>>(s);
                    comboBox3.DataSource = arr;
                    comboBox3.DisplayMember = "Name";
                    comboBox3.ValueMember = "Id";
                    this.ProductsList = arr;
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

        List<Product> ProductsList;
        List<Order> OrderList;

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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var order = new Order();


            if (this.comboBox3.SelectedValue != null)
            {
                order.Product_Id = Convert.ToInt64(this.comboBox3.SelectedValue);
            }
            else
            {
                return;
            }
            var quantity = textBox1.Text;

            if (int.TryParse(quantity, out var parsedQuantity))
            {
                order.Quantity = parsedQuantity;
            }
            else
            {
                return;
            }

            this.OrderList.Add(order);

            var list = new BindingList<Order>(this.OrderList);
            var data = new BindingSource(list, null);
            dataGridView1.DataSource = data;

            this.TotalPrice(order.Product_Id, order.Quantity);
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private async void Envoyer_Click_1(object sender, EventArgs e)
        {
            var purchaseOrder = new PurchaseOrder();

            if (this.comboBox2.SelectedValue != null)
            {
                purchaseOrder.Supplier_Id = Convert.ToInt64(this.comboBox2.SelectedValue);
            }
            else
            {
                return;
            }

            if (this.OrderList.Count < 1)
            {
                return;
            }

            purchaseOrder.Orders = this.OrderList;
           
            var jsonString = System.Text.Json.JsonSerializer.Serialize(purchaseOrder);

            HttpContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/PurchaseOrders"), content));

            this.Visible = false;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (this.OrderList.Count < 1)
            {
                return;
            }
            var order = OrderList[OrderList.Count - 1];

            this.OrderList.RemoveAt(this.OrderList.Count - 1);
            var list = new BindingList<Order>(this.OrderList);
            var data = new BindingSource(list, null);
            dataGridView1.DataSource = data;

               
                var product = this.ProductsList.Find(p => p.Id == order.Product_Id);
                var totalPrice = product.Price * order.Quantity;
                var lastTotal = label6.Text;
            if (double.TryParse(lastTotal, out var parsedPrice))
            {
                parsedPrice -= totalPrice;
                label6.Text = parsedPrice.ToString();
            }
   
        }

        private void TotalPrice(long selectedId, long quantity)
        {
            var product = this.ProductsList.Find(p => p.Id == selectedId);
            var totalPrice = product.Price * quantity;
            var lastTotal = label6.Text;
                if (double.TryParse(lastTotal, out var parsedPrice))
            {
                parsedPrice += totalPrice;
                label6.Text = parsedPrice.ToString();
            }
        }
    }
}
