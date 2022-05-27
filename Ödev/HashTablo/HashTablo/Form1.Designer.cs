
namespace HashTablo
{
    partial class v
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
            this.KlasorOlustur = new System.Windows.Forms.Button();
            this.txtYazım = new System.Windows.Forms.TextBox();
            this.lblKlasorAd = new System.Windows.Forms.Label();
            this.btnKlasorSıl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMetınYukle = new System.Windows.Forms.Button();
            this.btnKlasorYol = new System.Windows.Forms.Button();
            this.lblKlasorYol = new System.Windows.Forms.Label();
            this.txtKlasorYol = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListeYaz = new System.Windows.Forms.Button();
            this.txtGoruntule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KlasorOlustur
            // 
            this.KlasorOlustur.Location = new System.Drawing.Point(80, 44);
            this.KlasorOlustur.Name = "KlasorOlustur";
            this.KlasorOlustur.Size = new System.Drawing.Size(152, 30);
            this.KlasorOlustur.TabIndex = 0;
            this.KlasorOlustur.Text = "Klasor Yarat";
            this.KlasorOlustur.UseVisualStyleBackColor = true;
            this.KlasorOlustur.Click += new System.EventHandler(this.KlasorOlustur_Click);
            // 
            // txtYazım
            // 
            this.txtYazım.Location = new System.Drawing.Point(418, 47);
            this.txtYazım.Name = "txtYazım";
            this.txtYazım.Size = new System.Drawing.Size(100, 22);
            this.txtYazım.TabIndex = 1;
            // 
            // lblKlasorAd
            // 
            this.lblKlasorAd.AutoSize = true;
            this.lblKlasorAd.Location = new System.Drawing.Point(314, 50);
            this.lblKlasorAd.Name = "lblKlasorAd";
            this.lblKlasorAd.Size = new System.Drawing.Size(69, 17);
            this.lblKlasorAd.TabIndex = 2;
            this.lblKlasorAd.Text = "Klasor Ad";
            // 
            // btnKlasorSıl
            // 
            this.btnKlasorSıl.Location = new System.Drawing.Point(80, 89);
            this.btnKlasorSıl.Name = "btnKlasorSıl";
            this.btnKlasorSıl.Size = new System.Drawing.Size(152, 30);
            this.btnKlasorSıl.TabIndex = 3;
            this.btnKlasorSıl.Text = "Klasor Sil";
            this.btnKlasorSıl.UseVisualStyleBackColor = true;
            this.btnKlasorSıl.Click += new System.EventHandler(this.btnKlasorSıl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(300, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 180);
            this.listBox1.TabIndex = 4;
            // 
            // btnMetınYukle
            // 
            this.btnMetınYukle.Location = new System.Drawing.Point(80, 182);
            this.btnMetınYukle.Name = "btnMetınYukle";
            this.btnMetınYukle.Size = new System.Drawing.Size(152, 30);
            this.btnMetınYukle.TabIndex = 5;
            this.btnMetınYukle.Text = "Metın Yukle";
            this.btnMetınYukle.UseVisualStyleBackColor = true;
            this.btnMetınYukle.Click += new System.EventHandler(this.btnMetınYukle_Click);
            // 
            // btnKlasorYol
            // 
            this.btnKlasorYol.Location = new System.Drawing.Point(80, 136);
            this.btnKlasorYol.Name = "btnKlasorYol";
            this.btnKlasorYol.Size = new System.Drawing.Size(152, 30);
            this.btnKlasorYol.TabIndex = 6;
            this.btnKlasorYol.Text = "Klasor Yolu";
            this.btnKlasorYol.UseVisualStyleBackColor = true;
            this.btnKlasorYol.Click += new System.EventHandler(this.btnKlasorYol_Click);
            // 
            // lblKlasorYol
            // 
            this.lblKlasorYol.AutoSize = true;
            this.lblKlasorYol.BackColor = System.Drawing.Color.Chocolate;
            this.lblKlasorYol.Location = new System.Drawing.Point(314, 96);
            this.lblKlasorYol.Name = "lblKlasorYol";
            this.lblKlasorYol.Size = new System.Drawing.Size(80, 17);
            this.lblKlasorYol.TabIndex = 7;
            this.lblKlasorYol.Text = "Klasor Yolu";
            // 
            // txtKlasorYol
            // 
            this.txtKlasorYol.Location = new System.Drawing.Point(418, 97);
            this.txtKlasorYol.Name = "txtKlasorYol";
            this.txtKlasorYol.Size = new System.Drawing.Size(100, 22);
            this.txtKlasorYol.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(80, 231);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(152, 30);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListeYaz
            // 
            this.btnListeYaz.Location = new System.Drawing.Point(80, 280);
            this.btnListeYaz.Name = "btnListeYaz";
            this.btnListeYaz.Size = new System.Drawing.Size(152, 31);
            this.btnListeYaz.TabIndex = 10;
            this.btnListeYaz.Text = "Listeye Aktar";
            this.btnListeYaz.UseVisualStyleBackColor = true;
            this.btnListeYaz.Click += new System.EventHandler(this.btnListeYaz_Click);
            // 
            // txtGoruntule
            // 
            this.txtGoruntule.Location = new System.Drawing.Point(375, 154);
            this.txtGoruntule.Name = "txtGoruntule";
            this.txtGoruntule.Size = new System.Drawing.Size(143, 22);
            this.txtGoruntule.TabIndex = 11;
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGoruntule);
            this.Controls.Add(this.btnListeYaz);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKlasorYol);
            this.Controls.Add(this.lblKlasorYol);
            this.Controls.Add(this.btnKlasorYol);
            this.Controls.Add(this.btnMetınYukle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKlasorSıl);
            this.Controls.Add(this.lblKlasorAd);
            this.Controls.Add(this.txtYazım);
            this.Controls.Add(this.KlasorOlustur);
            this.Name = "v";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KlasorOlustur;
        private System.Windows.Forms.TextBox txtYazım;
        private System.Windows.Forms.Label lblKlasorAd;
        private System.Windows.Forms.Button btnKlasorSıl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMetınYukle;
        private System.Windows.Forms.Button btnKlasorYol;
        private System.Windows.Forms.Label lblKlasorYol;
        private System.Windows.Forms.TextBox txtKlasorYol;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListeYaz;
        private System.Windows.Forms.TextBox txtGoruntule;
    }
}

