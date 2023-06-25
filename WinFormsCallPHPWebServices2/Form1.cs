using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsCallPHPWebServices2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCallWebService_Click(object sender, EventArgs e)
        {
            PhpWebService.SoapPHPDemo sv = new PhpWebService.SoapPHPDemo();
            string s = sv.GetUserByName(txtName.Text.Trim());

            var jsonList = JsonConvert.DeserializeObject<List<User>>(s);

            dtServiceResult.DataSource = jsonList;

        }
    }
}
