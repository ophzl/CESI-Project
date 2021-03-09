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
            this.formProduct.Visible = false;
            this.formCustomer.Visible = false;
        }
        CustormerForm formCustomer;
        ProductForm formProduct;

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
        private void materialFlatButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
