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
using winform.forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace winform
{
    public partial class Wine : MaterialForm
    {
        public Wine()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
            this.formProduct = new ProductForm();
            this.formCustomer = new CustormerForm();
            this.formWineFamily = new WineFamilyForm();
            this.formSupplier = new SupplierForm();
            this.formPurchaseOrder = new PurchaseOrderForm();

            this.formProduct.Visible = false;
            this.formCustomer.Visible = false;
            this.formWineFamily.Visible = false;
            this.formSupplier.Visible = false;
            this.formSupplier.Visible = false;
            this.formPurchaseOrder.Visible = false;
        }
        CustormerForm formCustomer;
        ProductForm formProduct;
        WineFamilyForm formWineFamily;
        SupplierForm formSupplier;
        PurchaseOrderForm formPurchaseOrder;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://localhost:5001/api/products/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<Product>>(s);
                    var list = new BindingList<Product>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView1.DataSource = data;

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

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

            try
            {
                var url = "https://localhost:5001/api/customers/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<Customer>>(s);
                    var list = new BindingList<Customer>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView2.DataSource = data;

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

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {

            try
            {
                var url = "https://localhost:5001/api/winefamilies/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<WineFamily>>(s);
                    var list = new BindingList<WineFamily>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView3.DataSource = data;

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

        private void materialFlatButton8_Click(object sender, EventArgs e)
        {

            try
            {
                var url = "https://localhost:5001/api/suppliers/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<Supplier>>(s);
                    var list = new BindingList<Supplier>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView4.DataSource = data;

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

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {

            try
            {
                var url = "https://localhost:5001/api/purchaseorders/";
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<PurchaseOrder>>(s);
                    var list = new BindingList<PurchaseOrder>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView5.DataSource = data;

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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.formProduct.Visible = true;
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
                this.formCustomer.Visible = true;
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            this.formWineFamily.Visible = true;
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            this.formSupplier.Visible = true;
        }

        private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            this.formPurchaseOrder.Visible = true;
        }

        private void materialFlatButton12_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView2.SelectedRows)
            {
                Customer cust = row.DataBoundItem as Customer;
                if (cust != null)
                {
                   new CustormerFormEdit(cust).Visible = true;
                }
            }
        }

        private async void materialFlatButton11_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                Customer cust = row.DataBoundItem as Customer;
                dataGridView2.Rows.RemoveAt(row.Index);
                await deleteEntityAsync("customers", cust.Id);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView4.SelectedRows)
            {
                Supplier sup = row.DataBoundItem as Supplier;
                if (sup != null)
                {
                    new SupplierFormEdit(sup).Visible = true;
                }
            }
        }

        private async void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView4.SelectedRows)
            {
                Supplier sup = row.DataBoundItem as Supplier;
                dataGridView4.Rows.RemoveAt(row.Index);
                await deleteEntityAsync("suppliers", sup.Id);
            }
        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView3.SelectedRows)
            {
                WineFamily family = row.DataBoundItem as WineFamily;
                if (family != null)
                {
                    new WineFamilyFormEdit(family).Visible = true;
                }
            }
        }

        private async void materialFlatButton15_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                WineFamily family = row.DataBoundItem as WineFamily;
                dataGridView3.Rows.RemoveAt(row.Index);
                await deleteEntityAsync("wineFamilies", family.Id);
            }
        }

        private void materialFlatButton17_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Product product = row.DataBoundItem as Product;
                if (product != null)
                {
                    new ProductFormEdit(product).Visible = true;
                }
            }
        }

        private async void materialFlatButton18_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                Product product = row.DataBoundItem as Product;
                dataGridView1.Rows.RemoveAt(row.Index);
                await deleteEntityAsync("products", product.Id);
            }
        }

        private async Task deleteEntityAsync(string entityName, long entityId)
        {
            HttpContent content = new StringContent( "", Encoding.UTF8, "application/json");
            var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/" + entityName + '/' + entityId), content));
        }

        static async Task<string> SendURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
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
    }
}
