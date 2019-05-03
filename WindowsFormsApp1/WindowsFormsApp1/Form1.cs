using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            bool success;
            using(CustomersServices.ConvertSoapClient Login = new CustomersServices.ConvertSoapClient())
            {
                success = Login.LoginCheck(txtAd.Text, txtPass.Text);
                txtAd.Text = "";
                txtPass.Text = "";
            }
            var message = success ? "Başarılı!" : "Başarısız!";
            MessageBox.Show("Giriş işlemi "+ message);
            if (success)
            {
                this.Hide();
                mainForm mdiParent = new mainForm();
                mdiParent.Show();
            }
                
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
