namespace WindowsFormsApp1
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sirketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriToolStripMenuItem,
            this.sirketToolStripMenuItem,
            this.araclarToolStripMenuItem,
            this.kiralamaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(822, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem});
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.musteriToolStripMenuItem.Text = "Müşteri";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            this.islemlerToolStripMenuItem.Click += new System.EventHandler(this.islemlerToolStripMenuItem_Click);
            // 
            // sirketToolStripMenuItem
            // 
            this.sirketToolStripMenuItem.Name = "sirketToolStripMenuItem";
            this.sirketToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sirketToolStripMenuItem.Text = "Şirket";
            this.sirketToolStripMenuItem.Click += new System.EventHandler(this.sirketToolStripMenuItem_Click);
            // 
            // araclarToolStripMenuItem
            // 
            this.araclarToolStripMenuItem.Name = "araclarToolStripMenuItem";
            this.araclarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.araclarToolStripMenuItem.Text = "Arabalar";
            this.araclarToolStripMenuItem.Click += new System.EventHandler(this.araclarToolStripMenuItem_Click);
            // 
            // kiralamaToolStripMenuItem
            // 
            this.kiralamaToolStripMenuItem.Name = "kiralamaToolStripMenuItem";
            this.kiralamaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.kiralamaToolStripMenuItem.Text = "Kiralama";
            this.kiralamaToolStripMenuItem.Click += new System.EventHandler(this.kiralamaToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 598);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Car System | Win Form Application  - Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sirketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araclarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaToolStripMenuItem;
    }
}



