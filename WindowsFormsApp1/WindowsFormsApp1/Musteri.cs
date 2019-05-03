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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

    

        private void Musteri_Load(object sender, EventArgs e)
        {
            try
            {
                using (CustomersServices.ConvertSoapClient client = new CustomersServices.ConvertSoapClient())
                {
                    List<Customers> customers = new List<Customers>();
                    foreach (var item in client.GetCustomer().OrderBy(x => x.Musteri_ID).ToList())
                    {
                        Customers castedCustomer = new Customers()
                        {
                            Musteri_ID = item.Musteri_ID,
                            Musteri_Ad = item.Musteri_Ad,
                            Musteri_Soyad = item.Musteri_Soyad,
                            Musteri_KullaniciAdi = item.Musteri_KullaniciAdi,
                            Musteri_TC = item.Musteri_TC

                        };
                        customers.Add(castedCustomer);

                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = customers.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using (CustomersServices.ConvertSoapClient client = new CustomersServices.ConvertSoapClient())
                {
                    success = client.InsertCustomer(new CustomersServices.Customers()
                    {
                        Musteri_Ad = adTxt.Text,
                        Musteri_Soyad = txtSoyad.Text,
                        Musteri_KullaniciAdi = txtUname.Text,
                        Musteri_TC = txtTC.Text,
                        Musteri_Sifre = txtPass.Text
                    });
                }
                var msg = success ? "başarılı!" : "başarısız!";

                MessageBox.Show("İşlem " + msg);
                adTxt.Text = "";
                txtSoyad.Text = "";
                txtUname.Text = "";
                txtTC.Text = "";
                txtPass.Text = "";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool success;
                using(CustomersServices.ConvertSoapClient delete = new CustomersServices.ConvertSoapClient())
                {
                    success = delete.DeleteCustomer(int.Parse(txtMusteriID.Text));
                    
                }
                var msg = success ? "başarılı!" : "başarısız!";

                MessageBox.Show("Silme islemi " + msg);
                txtMusteriID.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Boş gecilemez!");
                throw;
            }
        }

        private void groupBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CustomersServices.ConvertSoapClient client = new CustomersServices.ConvertSoapClient();
                
                var item = client.CustomerFind(int.Parse(txtMusteriID.Text));

                lblMusteriAd.Text = item.Musteri_Ad;
                lblMusteriSAd.Text = item.Musteri_Soyad;
                lblMusteriKAd.Text = item.Musteri_KullaniciAdi;
                
            }
            catch (Exception)
            {
                lblMusteriAd.Text = "";
                lblMusteriKAd.Text = "";
                lblMusteriSAd.Text = "";
            }
        }
    }
}
