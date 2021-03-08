using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var url = "https://localhost:44343/weatherforecast";
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                /*var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<Dto>>(s);
                var list = new BindingList<Dto>(arr);
                var data = new BindingSource(list, null);
                dataGridView1.DataSource = data;*/

            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }
    }
}
