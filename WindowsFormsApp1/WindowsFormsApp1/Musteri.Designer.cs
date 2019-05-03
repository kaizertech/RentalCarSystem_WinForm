namespace WindowsFormsApp1
{
    partial class Musteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.lbl_recieverbalance = new System.Windows.Forms.Label();
            this.lblMusteriKAd = new System.Windows.Forms.Label();
            this.lbl_recieversurname = new System.Windows.Forms.Label();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.lbl_recievername = new System.Windows.Forms.Label();
            this.lblMusteriSAd = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(17, 315);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(67, 13);
            this.lblTC.TabIndex = 20;
            this.lblTC.Text = "Tc Kimlik No";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(117, 356);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(155, 20);
            this.txtPass.TabIndex = 19;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(17, 234);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(74, 13);
            this.lblSoyad.TabIndex = 18;
            this.lblSoyad.Text = "Müşteri Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(118, 231);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(154, 20);
            this.txtSoyad.TabIndex = 17;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(17, 359);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 13);
            this.lblPass.TabIndex = 16;
            this.lblPass.Text = "Müşteri Şifre";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(117, 272);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(155, 20);
            this.txtUname.TabIndex = 15;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 275);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 13);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "Müşteri Kullancı Adı";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(117, 312);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(155, 20);
            this.txtTC.TabIndex = 13;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(17, 195);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(57, 13);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Müşteri Ad";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(118, 192);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(154, 20);
            this.adTxt.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 387);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(252, 39);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMusteriID);
            this.groupBox2.Controls.Add(this.lbl_recieverbalance);
            this.groupBox2.Controls.Add(this.lblMusteriKAd);
            this.groupBox2.Controls.Add(this.lbl_recieversurname);
            this.groupBox2.Controls.Add(this.lblMusteriID);
            this.groupBox2.Controls.Add(this.lblMusteriAd);
            this.groupBox2.Controls.Add(this.lbl_recievername);
            this.groupBox2.Controls.Add(this.lblMusteriSAd);
            this.groupBox2.Location = new System.Drawing.Point(374, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 146);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musteri Bilgileri";
            this.groupBox2.TextChanged += new System.EventHandler(this.groupBox2_TextChanged);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(108, 23);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriID.TabIndex = 4;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            // 
            // lbl_recieverbalance
            // 
            this.lbl_recieverbalance.AutoSize = true;
            this.lbl_recieverbalance.Location = new System.Drawing.Point(105, 104);
            this.lbl_recieverbalance.Name = "lbl_recieverbalance";
            this.lbl_recieverbalance.Size = new System.Drawing.Size(0, 13);
            this.lbl_recieverbalance.TabIndex = 14;
            // 
            // lblMusteriKAd
            // 
            this.lblMusteriKAd.AutoSize = true;
            this.lblMusteriKAd.Location = new System.Drawing.Point(105, 106);
            this.lblMusteriKAd.Name = "lblMusteriKAd";
            this.lblMusteriKAd.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriKAd.TabIndex = 3;
            // 
            // lbl_recieversurname
            // 
            this.lbl_recieversurname.AutoSize = true;
            this.lbl_recieversurname.Location = new System.Drawing.Point(105, 77);
            this.lbl_recieversurname.Name = "lbl_recieversurname";
            this.lbl_recieversurname.Size = new System.Drawing.Size(0, 13);
            this.lbl_recieversurname.TabIndex = 14;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(6, 26);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(55, 13);
            this.lblMusteriID.TabIndex = 3;
            this.lblMusteriID.Text = "Müşteri ID";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(105, 52);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriAd.TabIndex = 3;
            // 
            // lbl_recievername
            // 
            this.lbl_recievername.AutoSize = true;
            this.lbl_recievername.Location = new System.Drawing.Point(105, 52);
            this.lbl_recievername.Name = "lbl_recievername";
            this.lbl_recievername.Size = new System.Drawing.Size(0, 13);
            this.lbl_recievername.TabIndex = 14;
            // 
            // lblMusteriSAd
            // 
            this.lblMusteriSAd.AutoSize = true;
            this.lblMusteriSAd.Location = new System.Drawing.Point(105, 77);
            this.lblMusteriSAd.Name = "lblMusteriSAd";
            this.lblMusteriSAd.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriSAd.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(365, 387);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(252, 39);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Müşteri Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Müşteri Kullanıcı adı";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 437);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Musteri";
            this.Text = "Musteri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label lbl_recieverbalance;
        private System.Windows.Forms.Label lblMusteriKAd;
        private System.Windows.Forms.Label lbl_recieversurname;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lbl_recievername;
        private System.Windows.Forms.Label lblMusteriSAd;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}