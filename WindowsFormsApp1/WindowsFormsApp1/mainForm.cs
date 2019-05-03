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
    public partial class mainForm : Form
    {
        

        public mainForm()
        {
            InitializeComponent();
            this.ActiveForms = new Dictionary<Type, Form>();
        }
    
        private Dictionary<Type, Form> ActiveForms;
        /// <summary>
        /// Mdi parent yapısında formların doğru çalışması için ufak bir code _:D
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        private void ShowForm<TSource>() where TSource : Form
        {
            Form form = null;
            if (this.ActiveForms.ContainsKey(typeof(TSource)))
            {
                form = this.ActiveForms[typeof(TSource)];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {
                form = Activator.CreateInstance<TSource>();
                form.MdiParent = this;
                form.FormClosed += form_FormClosed;
                form.Show();

                this.ActiveForms.Add(typeof(TSource), form);
            }
        }
        // formlar kapatıldığında Dictionary den kaldırıyoruz...
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }

        private void islemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<WindowsFormsApp1.Musteri>();
        }

        private void sirketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<WindowsFormsApp1.Sirket>();
        }

        private void araclarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<WindowsFormsApp1.Araclar>();
        }

        private void kiralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<WindowsFormsApp1.Kiralama>();
        }
    }
}
