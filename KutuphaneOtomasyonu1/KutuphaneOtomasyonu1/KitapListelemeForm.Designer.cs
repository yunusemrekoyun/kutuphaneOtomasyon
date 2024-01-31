namespace KutuphaneOtomasyonu1
{
    partial class KitapListelemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapListelemeForm));
            this.TuruCombo = new System.Windows.Forms.ComboBox();
            this.KitapEkleBtnİptal = new System.Windows.Forms.Button();
            this.KitapGuncelleBtn = new System.Windows.Forms.Button();
            this.AciklamaLabel = new System.Windows.Forms.Label();
            this.RafNumarasiLabel = new System.Windows.Forms.Label();
            this.StokSayisiLabel = new System.Windows.Forms.Label();
            this.TuruLabel = new System.Windows.Forms.Label();
            this.SayfaSayisiLabel = new System.Windows.Forms.Label();
            this.YayıneviLabel = new System.Windows.Forms.Label();
            this.YazariLabel = new System.Windows.Forms.Label();
            this.KitapAdiLabel = new System.Windows.Forms.Label();
            this.KitapBarkodNumarasiLabel = new System.Windows.Forms.Label();
            this.AciklamaText = new System.Windows.Forms.TextBox();
            this.RafNumarasiText = new System.Windows.Forms.TextBox();
            this.StokSayisiText = new System.Windows.Forms.TextBox();
            this.SayfaSayisiText = new System.Windows.Forms.TextBox();
            this.YayineviText = new System.Windows.Forms.TextBox();
            this.YazariText = new System.Windows.Forms.TextBox();
            this.KitapAdiText = new System.Windows.Forms.TextBox();
            this.KitapBarkodNumarasiText = new System.Windows.Forms.TextBox();
            this.KitapListeleyenGrid = new System.Windows.Forms.DataGridView();
            this.KitapSilBtn = new System.Windows.Forms.Button();
            this.KitapBarkodNumarasiİleAramaLabel = new System.Windows.Forms.Label();
            this.KitapBarkodNumarasiIleAramaText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KitapListeleyenGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TuruCombo
            // 
            this.TuruCombo.FormattingEnabled = true;
            this.TuruCombo.Items.AddRange(new object[] {
            "Roman",
            "Psikoloji",
            "Kişisel Gelişim",
            "Tarih",
            "Çocuk Kitabı"});
            this.TuruCombo.Location = new System.Drawing.Point(212, 241);
            this.TuruCombo.Name = "TuruCombo";
            this.TuruCombo.Size = new System.Drawing.Size(121, 21);
            this.TuruCombo.TabIndex = 40;
            // 
            // KitapEkleBtnİptal
            // 
            this.KitapEkleBtnİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.KitapEkleBtnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitapEkleBtnİptal.Location = new System.Drawing.Point(255, 413);
            this.KitapEkleBtnİptal.Name = "KitapEkleBtnİptal";
            this.KitapEkleBtnİptal.Size = new System.Drawing.Size(75, 23);
            this.KitapEkleBtnİptal.TabIndex = 39;
            this.KitapEkleBtnİptal.Text = "İptal";
            this.KitapEkleBtnİptal.UseVisualStyleBackColor = false;
            this.KitapEkleBtnİptal.Click += new System.EventHandler(this.KitapEkleBtnİptal_Click);
            // 
            // KitapGuncelleBtn
            // 
            this.KitapGuncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.KitapGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitapGuncelleBtn.Location = new System.Drawing.Point(146, 413);
            this.KitapGuncelleBtn.Name = "KitapGuncelleBtn";
            this.KitapGuncelleBtn.Size = new System.Drawing.Size(75, 23);
            this.KitapGuncelleBtn.TabIndex = 38;
            this.KitapGuncelleBtn.Text = "Güncelle";
            this.KitapGuncelleBtn.UseVisualStyleBackColor = false;
            this.KitapGuncelleBtn.Click += new System.EventHandler(this.KitapGuncelleBtn_Click);
            // 
            // AciklamaLabel
            // 
            this.AciklamaLabel.AutoSize = true;
            this.AciklamaLabel.Location = new System.Drawing.Point(62, 376);
            this.AciklamaLabel.Name = "AciklamaLabel";
            this.AciklamaLabel.Size = new System.Drawing.Size(50, 13);
            this.AciklamaLabel.TabIndex = 37;
            this.AciklamaLabel.Text = "Açıklama";
            // 
            // RafNumarasiLabel
            // 
            this.RafNumarasiLabel.AutoSize = true;
            this.RafNumarasiLabel.Location = new System.Drawing.Point(62, 340);
            this.RafNumarasiLabel.Name = "RafNumarasiLabel";
            this.RafNumarasiLabel.Size = new System.Drawing.Size(71, 13);
            this.RafNumarasiLabel.TabIndex = 36;
            this.RafNumarasiLabel.Text = "Raf Numarası";
            // 
            // StokSayisiLabel
            // 
            this.StokSayisiLabel.AutoSize = true;
            this.StokSayisiLabel.Location = new System.Drawing.Point(62, 292);
            this.StokSayisiLabel.Name = "StokSayisiLabel";
            this.StokSayisiLabel.Size = new System.Drawing.Size(59, 13);
            this.StokSayisiLabel.TabIndex = 35;
            this.StokSayisiLabel.Text = "Stok Sayısı";
            // 
            // TuruLabel
            // 
            this.TuruLabel.AutoSize = true;
            this.TuruLabel.Location = new System.Drawing.Point(62, 241);
            this.TuruLabel.Name = "TuruLabel";
            this.TuruLabel.Size = new System.Drawing.Size(29, 13);
            this.TuruLabel.TabIndex = 34;
            this.TuruLabel.Text = "Türü";
            // 
            // SayfaSayisiLabel
            // 
            this.SayfaSayisiLabel.AutoSize = true;
            this.SayfaSayisiLabel.Location = new System.Drawing.Point(62, 197);
            this.SayfaSayisiLabel.Name = "SayfaSayisiLabel";
            this.SayfaSayisiLabel.Size = new System.Drawing.Size(64, 13);
            this.SayfaSayisiLabel.TabIndex = 33;
            this.SayfaSayisiLabel.Text = "Sayfa Sayısı";
            // 
            // YayıneviLabel
            // 
            this.YayıneviLabel.AutoSize = true;
            this.YayıneviLabel.Location = new System.Drawing.Point(62, 155);
            this.YayıneviLabel.Name = "YayıneviLabel";
            this.YayıneviLabel.Size = new System.Drawing.Size(47, 13);
            this.YayıneviLabel.TabIndex = 32;
            this.YayıneviLabel.Text = "Yayınevi";
            // 
            // YazariLabel
            // 
            this.YazariLabel.AutoSize = true;
            this.YazariLabel.Location = new System.Drawing.Point(62, 119);
            this.YazariLabel.Name = "YazariLabel";
            this.YazariLabel.Size = new System.Drawing.Size(36, 13);
            this.YazariLabel.TabIndex = 31;
            this.YazariLabel.Text = "Yazarı";
            // 
            // KitapAdiLabel
            // 
            this.KitapAdiLabel.AutoSize = true;
            this.KitapAdiLabel.Location = new System.Drawing.Point(62, 67);
            this.KitapAdiLabel.Name = "KitapAdiLabel";
            this.KitapAdiLabel.Size = new System.Drawing.Size(49, 13);
            this.KitapAdiLabel.TabIndex = 30;
            this.KitapAdiLabel.Text = "Kitap Adı";
            // 
            // KitapBarkodNumarasiLabel
            // 
            this.KitapBarkodNumarasiLabel.AutoSize = true;
            this.KitapBarkodNumarasiLabel.Location = new System.Drawing.Point(62, 19);
            this.KitapBarkodNumarasiLabel.Name = "KitapBarkodNumarasiLabel";
            this.KitapBarkodNumarasiLabel.Size = new System.Drawing.Size(115, 13);
            this.KitapBarkodNumarasiLabel.TabIndex = 29;
            this.KitapBarkodNumarasiLabel.Text = "Kitap Barkod Numarası";
            // 
            // AciklamaText
            // 
            this.AciklamaText.Location = new System.Drawing.Point(212, 373);
            this.AciklamaText.Multiline = true;
            this.AciklamaText.Name = "AciklamaText";
            this.AciklamaText.Size = new System.Drawing.Size(100, 20);
            this.AciklamaText.TabIndex = 28;
            // 
            // RafNumarasiText
            // 
            this.RafNumarasiText.Location = new System.Drawing.Point(212, 333);
            this.RafNumarasiText.Name = "RafNumarasiText";
            this.RafNumarasiText.Size = new System.Drawing.Size(100, 20);
            this.RafNumarasiText.TabIndex = 27;
            // 
            // StokSayisiText
            // 
            this.StokSayisiText.Location = new System.Drawing.Point(212, 289);
            this.StokSayisiText.Name = "StokSayisiText";
            this.StokSayisiText.Size = new System.Drawing.Size(100, 20);
            this.StokSayisiText.TabIndex = 26;
            // 
            // SayfaSayisiText
            // 
            this.SayfaSayisiText.Location = new System.Drawing.Point(212, 197);
            this.SayfaSayisiText.Name = "SayfaSayisiText";
            this.SayfaSayisiText.Size = new System.Drawing.Size(100, 20);
            this.SayfaSayisiText.TabIndex = 25;
            // 
            // YayineviText
            // 
            this.YayineviText.Location = new System.Drawing.Point(212, 152);
            this.YayineviText.Name = "YayineviText";
            this.YayineviText.Size = new System.Drawing.Size(100, 20);
            this.YayineviText.TabIndex = 24;
            // 
            // YazariText
            // 
            this.YazariText.Location = new System.Drawing.Point(212, 112);
            this.YazariText.Name = "YazariText";
            this.YazariText.Size = new System.Drawing.Size(100, 20);
            this.YazariText.TabIndex = 23;
            // 
            // KitapAdiText
            // 
            this.KitapAdiText.Location = new System.Drawing.Point(212, 60);
            this.KitapAdiText.Name = "KitapAdiText";
            this.KitapAdiText.Size = new System.Drawing.Size(100, 20);
            this.KitapAdiText.TabIndex = 22;
            // 
            // KitapBarkodNumarasiText
            // 
            this.KitapBarkodNumarasiText.Location = new System.Drawing.Point(212, 12);
            this.KitapBarkodNumarasiText.Name = "KitapBarkodNumarasiText";
            this.KitapBarkodNumarasiText.Size = new System.Drawing.Size(100, 20);
            this.KitapBarkodNumarasiText.TabIndex = 21;
            this.KitapBarkodNumarasiText.TextChanged += new System.EventHandler(this.KitapBarkodNumarasiText_TextChanged);
            // 
            // KitapListeleyenGrid
            // 
            this.KitapListeleyenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapListeleyenGrid.Location = new System.Drawing.Point(370, 67);
            this.KitapListeleyenGrid.Name = "KitapListeleyenGrid";
            this.KitapListeleyenGrid.Size = new System.Drawing.Size(330, 322);
            this.KitapListeleyenGrid.TabIndex = 41;
            // 
            // KitapSilBtn
            // 
            this.KitapSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.KitapSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitapSilBtn.Location = new System.Drawing.Point(625, 395);
            this.KitapSilBtn.Name = "KitapSilBtn";
            this.KitapSilBtn.Size = new System.Drawing.Size(75, 23);
            this.KitapSilBtn.TabIndex = 42;
            this.KitapSilBtn.Text = "Sil";
            this.KitapSilBtn.UseVisualStyleBackColor = false;
            this.KitapSilBtn.Click += new System.EventHandler(this.KitapSilBtn_Click);
            // 
            // KitapBarkodNumarasiİleAramaLabel
            // 
            this.KitapBarkodNumarasiİleAramaLabel.AutoSize = true;
            this.KitapBarkodNumarasiİleAramaLabel.Location = new System.Drawing.Point(367, 19);
            this.KitapBarkodNumarasiİleAramaLabel.Name = "KitapBarkodNumarasiİleAramaLabel";
            this.KitapBarkodNumarasiİleAramaLabel.Size = new System.Drawing.Size(148, 13);
            this.KitapBarkodNumarasiİleAramaLabel.TabIndex = 44;
            this.KitapBarkodNumarasiİleAramaLabel.Text = "Kitap Barkod Numarası İle Ara";
            // 
            // KitapBarkodNumarasiIleAramaText
            // 
            this.KitapBarkodNumarasiIleAramaText.Location = new System.Drawing.Point(532, 19);
            this.KitapBarkodNumarasiIleAramaText.Name = "KitapBarkodNumarasiIleAramaText";
            this.KitapBarkodNumarasiIleAramaText.Size = new System.Drawing.Size(100, 20);
            this.KitapBarkodNumarasiIleAramaText.TabIndex = 43;
            this.KitapBarkodNumarasiIleAramaText.TextChanged += new System.EventHandler(this.KitapBarkodNumarasiIleAramaText_TextChanged);
            // 
            // KitapListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.KitapBarkodNumarasiİleAramaLabel);
            this.Controls.Add(this.KitapBarkodNumarasiIleAramaText);
            this.Controls.Add(this.KitapSilBtn);
            this.Controls.Add(this.KitapListeleyenGrid);
            this.Controls.Add(this.TuruCombo);
            this.Controls.Add(this.KitapEkleBtnİptal);
            this.Controls.Add(this.KitapGuncelleBtn);
            this.Controls.Add(this.AciklamaLabel);
            this.Controls.Add(this.RafNumarasiLabel);
            this.Controls.Add(this.StokSayisiLabel);
            this.Controls.Add(this.TuruLabel);
            this.Controls.Add(this.SayfaSayisiLabel);
            this.Controls.Add(this.YayıneviLabel);
            this.Controls.Add(this.YazariLabel);
            this.Controls.Add(this.KitapAdiLabel);
            this.Controls.Add(this.KitapBarkodNumarasiLabel);
            this.Controls.Add(this.AciklamaText);
            this.Controls.Add(this.RafNumarasiText);
            this.Controls.Add(this.StokSayisiText);
            this.Controls.Add(this.SayfaSayisiText);
            this.Controls.Add(this.YayineviText);
            this.Controls.Add(this.YazariText);
            this.Controls.Add(this.KitapAdiText);
            this.Controls.Add(this.KitapBarkodNumarasiText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapListelemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.KitapListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KitapListeleyenGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TuruCombo;
        private System.Windows.Forms.Button KitapEkleBtnİptal;
        private System.Windows.Forms.Button KitapGuncelleBtn;
        private System.Windows.Forms.Label AciklamaLabel;
        private System.Windows.Forms.Label RafNumarasiLabel;
        private System.Windows.Forms.Label StokSayisiLabel;
        private System.Windows.Forms.Label TuruLabel;
        private System.Windows.Forms.Label SayfaSayisiLabel;
        private System.Windows.Forms.Label YayıneviLabel;
        private System.Windows.Forms.Label YazariLabel;
        private System.Windows.Forms.Label KitapAdiLabel;
        private System.Windows.Forms.Label KitapBarkodNumarasiLabel;
        private System.Windows.Forms.TextBox AciklamaText;
        private System.Windows.Forms.TextBox RafNumarasiText;
        private System.Windows.Forms.TextBox StokSayisiText;
        private System.Windows.Forms.TextBox SayfaSayisiText;
        private System.Windows.Forms.TextBox YayineviText;
        private System.Windows.Forms.TextBox YazariText;
        private System.Windows.Forms.TextBox KitapAdiText;
        private System.Windows.Forms.TextBox KitapBarkodNumarasiText;
        private System.Windows.Forms.DataGridView KitapListeleyenGrid;
        private System.Windows.Forms.Button KitapSilBtn;
        private System.Windows.Forms.Label KitapBarkodNumarasiİleAramaLabel;
        private System.Windows.Forms.TextBox KitapBarkodNumarasiIleAramaText;
    }
}