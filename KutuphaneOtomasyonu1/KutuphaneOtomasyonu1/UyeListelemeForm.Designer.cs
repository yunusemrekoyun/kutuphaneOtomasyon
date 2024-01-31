namespace KutuphaneOtomasyonu1
{
    partial class UyeListelemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListelemeForm));
            this.UyeListeleyenGrid = new System.Windows.Forms.DataGridView();
            this.İptalBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.OkunanKitapSayisiLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.TelefonLabel = new System.Windows.Forms.Label();
            this.CinsiyetLabel = new System.Windows.Forms.Label();
            this.YasLabel = new System.Windows.Forms.Label();
            this.AdSoyadLabel = new System.Windows.Forms.Label();
            this.TCLabel = new System.Windows.Forms.Label();
            this.CinsiyetCombo = new System.Windows.Forms.ComboBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.OkunanKitapSayisiText = new System.Windows.Forms.TextBox();
            this.AdSoyadText = new System.Windows.Forms.TextBox();
            this.YasText = new System.Windows.Forms.TextBox();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.TelefonText = new System.Windows.Forms.TextBox();
            this.TCText = new System.Windows.Forms.TextBox();
            this.TCAraText = new System.Windows.Forms.TextBox();
            this.TcAramaLabel = new System.Windows.Forms.Label();
            this.SilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UyeListeleyenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UyeListeleyenGrid
            // 
            this.UyeListeleyenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyeListeleyenGrid.Location = new System.Drawing.Point(355, 39);
            this.UyeListeleyenGrid.Name = "UyeListeleyenGrid";
            this.UyeListeleyenGrid.Size = new System.Drawing.Size(675, 360);
            this.UyeListeleyenGrid.TabIndex = 0;
            this.UyeListeleyenGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // İptalBtn
            // 
            this.İptalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.İptalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İptalBtn.Location = new System.Drawing.Point(955, 413);
            this.İptalBtn.Name = "İptalBtn";
            this.İptalBtn.Size = new System.Drawing.Size(75, 23);
            this.İptalBtn.TabIndex = 36;
            this.İptalBtn.Text = "İptal";
            this.İptalBtn.UseVisualStyleBackColor = false;
            this.İptalBtn.Click += new System.EventHandler(this.İptalBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.GuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuncelleBtn.Location = new System.Drawing.Point(140, 398);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(75, 23);
            this.GuncelleBtn.TabIndex = 35;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // OkunanKitapSayisiLabel
            // 
            this.OkunanKitapSayisiLabel.AutoSize = true;
            this.OkunanKitapSayisiLabel.Location = new System.Drawing.Point(23, 350);
            this.OkunanKitapSayisiLabel.Name = "OkunanKitapSayisiLabel";
            this.OkunanKitapSayisiLabel.Size = new System.Drawing.Size(102, 13);
            this.OkunanKitapSayisiLabel.TabIndex = 34;
            this.OkunanKitapSayisiLabel.Text = "Okunan Kitap Sayısı";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(23, 301);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 33;
            this.EmailLabel.Text = "E-mail";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(23, 254);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(34, 13);
            this.AdresLabel.TabIndex = 32;
            this.AdresLabel.Text = "Adres";
            // 
            // TelefonLabel
            // 
            this.TelefonLabel.AutoSize = true;
            this.TelefonLabel.Location = new System.Drawing.Point(23, 219);
            this.TelefonLabel.Name = "TelefonLabel";
            this.TelefonLabel.Size = new System.Drawing.Size(43, 13);
            this.TelefonLabel.TabIndex = 31;
            this.TelefonLabel.Text = "Telefon";
            // 
            // CinsiyetLabel
            // 
            this.CinsiyetLabel.AutoSize = true;
            this.CinsiyetLabel.Location = new System.Drawing.Point(23, 176);
            this.CinsiyetLabel.Name = "CinsiyetLabel";
            this.CinsiyetLabel.Size = new System.Drawing.Size(43, 13);
            this.CinsiyetLabel.TabIndex = 30;
            this.CinsiyetLabel.Text = "Cinsiyet";
            // 
            // YasLabel
            // 
            this.YasLabel.AutoSize = true;
            this.YasLabel.Location = new System.Drawing.Point(23, 130);
            this.YasLabel.Name = "YasLabel";
            this.YasLabel.Size = new System.Drawing.Size(25, 13);
            this.YasLabel.TabIndex = 29;
            this.YasLabel.Text = "Yaş";
            // 
            // AdSoyadLabel
            // 
            this.AdSoyadLabel.AutoSize = true;
            this.AdSoyadLabel.Location = new System.Drawing.Point(14, 74);
            this.AdSoyadLabel.Name = "AdSoyadLabel";
            this.AdSoyadLabel.Size = new System.Drawing.Size(53, 13);
            this.AdSoyadLabel.TabIndex = 28;
            this.AdSoyadLabel.Text = "Ad Soyad";
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Location = new System.Drawing.Point(23, 39);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(21, 13);
            this.TCLabel.TabIndex = 27;
            this.TCLabel.Text = "TC";
            // 
            // CinsiyetCombo
            // 
            this.CinsiyetCombo.FormattingEnabled = true;
            this.CinsiyetCombo.Items.AddRange(new object[] {
            "Bay\t",
            "Bayan"});
            this.CinsiyetCombo.Location = new System.Drawing.Point(140, 168);
            this.CinsiyetCombo.Name = "CinsiyetCombo";
            this.CinsiyetCombo.Size = new System.Drawing.Size(121, 21);
            this.CinsiyetCombo.TabIndex = 26;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(140, 298);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 20);
            this.EmailText.TabIndex = 25;
            // 
            // OkunanKitapSayisiText
            // 
            this.OkunanKitapSayisiText.Location = new System.Drawing.Point(140, 347);
            this.OkunanKitapSayisiText.Name = "OkunanKitapSayisiText";
            this.OkunanKitapSayisiText.Size = new System.Drawing.Size(100, 20);
            this.OkunanKitapSayisiText.TabIndex = 24;
            this.OkunanKitapSayisiText.Text = "0";
            this.OkunanKitapSayisiText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdSoyadText
            // 
            this.AdSoyadText.Location = new System.Drawing.Point(140, 67);
            this.AdSoyadText.Name = "AdSoyadText";
            this.AdSoyadText.Size = new System.Drawing.Size(100, 20);
            this.AdSoyadText.TabIndex = 23;
            // 
            // YasText
            // 
            this.YasText.Location = new System.Drawing.Point(140, 123);
            this.YasText.Name = "YasText";
            this.YasText.Size = new System.Drawing.Size(100, 20);
            this.YasText.TabIndex = 22;
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(140, 254);
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(100, 20);
            this.AdresText.TabIndex = 21;
            // 
            // TelefonText
            // 
            this.TelefonText.Location = new System.Drawing.Point(140, 212);
            this.TelefonText.Name = "TelefonText";
            this.TelefonText.Size = new System.Drawing.Size(100, 20);
            this.TelefonText.TabIndex = 20;
            // 
            // TCText
            // 
            this.TCText.Location = new System.Drawing.Point(140, 27);
            this.TCText.Name = "TCText";
            this.TCText.Size = new System.Drawing.Size(100, 20);
            this.TCText.TabIndex = 19;
            this.TCText.TextChanged += new System.EventHandler(this.TCText_TextChanged);
            // 
            // TCAraText
            // 
            this.TCAraText.Location = new System.Drawing.Point(511, 10);
            this.TCAraText.Name = "TCAraText";
            this.TCAraText.Size = new System.Drawing.Size(100, 20);
            this.TCAraText.TabIndex = 37;
            this.TCAraText.TextChanged += new System.EventHandler(this.TCAraText_TextChanged);
            // 
            // TcAramaLabel
            // 
            this.TcAramaLabel.AutoSize = true;
            this.TcAramaLabel.Location = new System.Drawing.Point(390, 13);
            this.TcAramaLabel.Name = "TcAramaLabel";
            this.TcAramaLabel.Size = new System.Drawing.Size(115, 13);
            this.TcAramaLabel.TabIndex = 38;
            this.TcAramaLabel.Text = "TC Numarası İle Arama";
            this.TcAramaLabel.Click += new System.EventHandler(this.TcAramaLabel_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Location = new System.Drawing.Point(896, 9);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(75, 24);
            this.SilBtn.TabIndex = 39;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // UyeListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1042, 448);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.TcAramaLabel);
            this.Controls.Add(this.TCAraText);
            this.Controls.Add(this.İptalBtn);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.OkunanKitapSayisiLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AdresLabel);
            this.Controls.Add(this.TelefonLabel);
            this.Controls.Add(this.CinsiyetLabel);
            this.Controls.Add(this.YasLabel);
            this.Controls.Add(this.AdSoyadLabel);
            this.Controls.Add(this.TCLabel);
            this.Controls.Add(this.CinsiyetCombo);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.OkunanKitapSayisiText);
            this.Controls.Add(this.AdSoyadText);
            this.Controls.Add(this.YasText);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.TelefonText);
            this.Controls.Add(this.TCText);
            this.Controls.Add(this.UyeListeleyenGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UyeListelemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.UyeListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UyeListeleyenGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UyeListeleyenGrid;
        private System.Windows.Forms.Button İptalBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Label OkunanKitapSayisiLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.Label TelefonLabel;
        private System.Windows.Forms.Label CinsiyetLabel;
        private System.Windows.Forms.Label YasLabel;
        private System.Windows.Forms.Label AdSoyadLabel;
        private System.Windows.Forms.Label TCLabel;
        private System.Windows.Forms.ComboBox CinsiyetCombo;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox OkunanKitapSayisiText;
        private System.Windows.Forms.TextBox AdSoyadText;
        private System.Windows.Forms.TextBox YasText;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.TextBox TelefonText;
        private System.Windows.Forms.TextBox TCText;
        private System.Windows.Forms.TextBox TCAraText;
        private System.Windows.Forms.Label TcAramaLabel;
        private System.Windows.Forms.Button SilBtn;
    }
}