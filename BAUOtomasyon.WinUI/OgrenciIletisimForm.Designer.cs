namespace BAUOtomasyon.WinUI
{
    partial class OgrenciIletisimForm
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
            this.dgrOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIletisimKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnIletisimKaydet2 = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.dgvOgrenciIletisim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrOgrenciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciIletisim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrOgrenciListesi
            // 
            this.dgrOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrOgrenciListesi.Location = new System.Drawing.Point(3, 88);
            this.dgrOgrenciListesi.Name = "dgrOgrenciListesi";
            this.dgrOgrenciListesi.RowTemplate.Height = 24;
            this.dgrOgrenciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrOgrenciListesi.Size = new System.Drawing.Size(498, 398);
            this.dgrOgrenciListesi.TabIndex = 0;
            this.dgrOgrenciListesi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrOgrenciListesi_MouseDoubleClick);
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(104, 33);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(220, 22);
            this.txtOgrenciAdi.TabIndex = 1;
            this.txtOgrenciAdi.TextChanged += new System.EventHandler(this.txtOgrenciAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(457, 504);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "E - Posta";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(457, 557);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(220, 22);
            this.txtEPosta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres";
            // 
            // btnIletisimKaydet
            // 
            this.btnIletisimKaydet.Location = new System.Drawing.Point(703, 504);
            this.btnIletisimKaydet.Name = "btnIletisimKaydet";
            this.btnIletisimKaydet.Size = new System.Drawing.Size(97, 75);
            this.btnIletisimKaydet.TabIndex = 9;
            this.btnIletisimKaydet.Text = "İletişim Kaydet";
            this.btnIletisimKaydet.UseVisualStyleBackColor = true;
            this.btnIletisimKaydet.Click += new System.EventHandler(this.btnIletisimKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(104, 614);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(573, 53);
            this.txtAdres.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(104, 557);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(220, 22);
            this.txtSoyad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 504);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(220, 22);
            this.txtAd.TabIndex = 10;
            // 
            // btnIletisimKaydet2
            // 
            this.btnIletisimKaydet2.Location = new System.Drawing.Point(703, 592);
            this.btnIletisimKaydet2.Name = "btnIletisimKaydet2";
            this.btnIletisimKaydet2.Size = new System.Drawing.Size(97, 75);
            this.btnIletisimKaydet2.TabIndex = 14;
            this.btnIletisimKaydet2.Text = "İletişim Kaydet2";
            this.btnIletisimKaydet2.UseVisualStyleBackColor = true;
            this.btnIletisimKaydet2.Click += new System.EventHandler(this.btnIletisimKaydet2_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(853, 504);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(97, 75);
            this.btnOgrenciSil.TabIndex = 15;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // dgvOgrenciIletisim
            // 
            this.dgvOgrenciIletisim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciIletisim.Location = new System.Drawing.Point(527, 88);
            this.dgvOgrenciIletisim.Name = "dgvOgrenciIletisim";
            this.dgvOgrenciIletisim.RowTemplate.Height = 24;
            this.dgvOgrenciIletisim.Size = new System.Drawing.Size(782, 398);
            this.dgvOgrenciIletisim.TabIndex = 16;
            // 
            // OgrenciIletisimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 679);
            this.Controls.Add(this.dgvOgrenciIletisim);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnIletisimKaydet2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnIletisimKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.dgrOgrenciListesi);
            this.Name = "OgrenciIletisimForm";
            this.Text = "OgrenciIletisimForm";
            this.Load += new System.EventHandler(this.OgrenciIletisimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrOgrenciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciIletisim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrOgrenciListesi;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIletisimKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnIletisimKaydet2;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.DataGridView dgvOgrenciIletisim;
    }
}