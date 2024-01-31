namespace KutuphaneOtomasyonu1
{
    partial class OduncKitapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncKitapForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeslimAlBtn = new System.Windows.Forms.Button();
            this.IptalBtn = new System.Windows.Forms.Button();
            this.TCIleAramaText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BarkodNoIleAramaText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeslimAlBtn
            // 
            this.TeslimAlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.TeslimAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeslimAlBtn.Location = new System.Drawing.Point(580, 396);
            this.TeslimAlBtn.Name = "TeslimAlBtn";
            this.TeslimAlBtn.Size = new System.Drawing.Size(75, 23);
            this.TeslimAlBtn.TabIndex = 1;
            this.TeslimAlBtn.Text = "Teslim Al";
            this.TeslimAlBtn.UseVisualStyleBackColor = false;
            this.TeslimAlBtn.Click += new System.EventHandler(this.TeslimAlBtn_Click);
            // 
            // IptalBtn
            // 
            this.IptalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.IptalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IptalBtn.Location = new System.Drawing.Point(680, 396);
            this.IptalBtn.Name = "IptalBtn";
            this.IptalBtn.Size = new System.Drawing.Size(75, 23);
            this.IptalBtn.TabIndex = 2;
            this.IptalBtn.Text = "İptal";
            this.IptalBtn.UseVisualStyleBackColor = false;
            this.IptalBtn.Click += new System.EventHandler(this.IptalBtn_Click);
            // 
            // TCIleAramaText
            // 
            this.TCIleAramaText.Location = new System.Drawing.Point(119, 8);
            this.TCIleAramaText.Name = "TCIleAramaText";
            this.TCIleAramaText.Size = new System.Drawing.Size(147, 20);
            this.TCIleAramaText.TabIndex = 3;
            this.TCIleAramaText.TextChanged += new System.EventHandler(this.TCIleAramaText_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC ile Arama";
            // 
            // BarkodNoIleAramaText
            // 
            this.BarkodNoIleAramaText.AutoSize = true;
            this.BarkodNoIleAramaText.Location = new System.Drawing.Point(288, 12);
            this.BarkodNoIleAramaText.Name = "BarkodNoIleAramaText";
            this.BarkodNoIleAramaText.Size = new System.Drawing.Size(105, 13);
            this.BarkodNoIleAramaText.TabIndex = 6;
            this.BarkodNoIleAramaText.Text = "Barkod No İle Arama";
            // 
            // OduncKitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarkodNoIleAramaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TCIleAramaText);
            this.Controls.Add(this.IptalBtn);
            this.Controls.Add(this.TeslimAlBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OduncKitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.OduncKitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TeslimAlBtn;
        private System.Windows.Forms.Button IptalBtn;
        private System.Windows.Forms.TextBox TCIleAramaText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BarkodNoIleAramaText;
    }
}