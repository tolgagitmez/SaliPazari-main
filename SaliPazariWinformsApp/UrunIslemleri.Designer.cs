﻿namespace SaliPazariWinformsApp
{
    partial class UrunIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ted_ekle = new System.Windows.Forms.Button();
            this.btn_marka_ekle = new System.Windows.Forms.Button();
            this.btn_kat_ekle = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_hizli = new System.Windows.Forms.CheckBox();
            this.cb_aktif = new System.Windows.Forms.CheckBox();
            this.nu_fiyat = new System.Windows.Forms.NumericUpDown();
            this.nu_GuvenlikStok = new System.Windows.Forms.NumericUpDown();
            this.tb_urunAdi = new System.Windows.Forms.TextBox();
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Tedarikci = new System.Windows.Forms.ComboBox();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_GuvenlikStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_ted_ekle);
            this.groupBox1.Controls.Add(this.btn_marka_ekle);
            this.groupBox1.Controls.Add(this.btn_kat_ekle);
            this.groupBox1.Controls.Add(this.btn_iptal);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.btn_resimSec);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cb_hizli);
            this.groupBox1.Controls.Add(this.cb_aktif);
            this.groupBox1.Controls.Add(this.nu_fiyat);
            this.groupBox1.Controls.Add(this.nu_GuvenlikStok);
            this.groupBox1.Controls.Add(this.tb_urunAdi);
            this.groupBox1.Controls.Add(this.tb_barkod);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_Tedarikci);
            this.groupBox1.Controls.Add(this.cb_marka);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1081, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // btn_ted_ekle
            // 
            this.btn_ted_ekle.Location = new System.Drawing.Point(393, 105);
            this.btn_ted_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ted_ekle.Name = "btn_ted_ekle";
            this.btn_ted_ekle.Size = new System.Drawing.Size(36, 28);
            this.btn_ted_ekle.TabIndex = 14;
            this.btn_ted_ekle.Text = "+";
            this.btn_ted_ekle.UseVisualStyleBackColor = true;
            this.btn_ted_ekle.Click += new System.EventHandler(this.btn_ted_ekle_Click);
            // 
            // btn_marka_ekle
            // 
            this.btn_marka_ekle.Location = new System.Drawing.Point(393, 73);
            this.btn_marka_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_marka_ekle.Name = "btn_marka_ekle";
            this.btn_marka_ekle.Size = new System.Drawing.Size(36, 28);
            this.btn_marka_ekle.TabIndex = 14;
            this.btn_marka_ekle.Text = "+";
            this.btn_marka_ekle.UseVisualStyleBackColor = true;
            this.btn_marka_ekle.Click += new System.EventHandler(this.btn_marka_ekle_Click);
            // 
            // btn_kat_ekle
            // 
            this.btn_kat_ekle.Location = new System.Drawing.Point(393, 41);
            this.btn_kat_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kat_ekle.Name = "btn_kat_ekle";
            this.btn_kat_ekle.Size = new System.Drawing.Size(36, 28);
            this.btn_kat_ekle.TabIndex = 14;
            this.btn_kat_ekle.Text = "+";
            this.btn_kat_ekle.UseVisualStyleBackColor = true;
            this.btn_kat_ekle.Click += new System.EventHandler(this.btn_kat_ekle_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(724, 140);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 28);
            this.btn_iptal.TabIndex = 13;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(616, 141);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(616, 140);
            this.btn_duzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(100, 28);
            this.btn_duzenle.TabIndex = 12;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Location = new System.Drawing.Point(616, 38);
            this.btn_resimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(100, 28);
            this.btn_resimSec.TabIndex = 11;
            this.btn_resimSec.Text = "Resim Ekle";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(451, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cb_hizli
            // 
            this.cb_hizli.AutoSize = true;
            this.cb_hizli.Location = new System.Drawing.Point(616, 105);
            this.cb_hizli.Margin = new System.Windows.Forms.Padding(4);
            this.cb_hizli.Name = "cb_hizli";
            this.cb_hizli.Size = new System.Drawing.Size(85, 20);
            this.cb_hizli.TabIndex = 9;
            this.cb_hizli.Text = "Hızlı Ürün";
            this.cb_hizli.UseVisualStyleBackColor = true;
            // 
            // cb_aktif
            // 
            this.cb_aktif.AutoSize = true;
            this.cb_aktif.Location = new System.Drawing.Point(616, 76);
            this.cb_aktif.Margin = new System.Windows.Forms.Padding(4);
            this.cb_aktif.Name = "cb_aktif";
            this.cb_aktif.Size = new System.Drawing.Size(85, 20);
            this.cb_aktif.TabIndex = 8;
            this.cb_aktif.Text = "Aktif Ürün";
            this.cb_aktif.UseVisualStyleBackColor = true;
            // 
            // nu_fiyat
            // 
            this.nu_fiyat.Location = new System.Drawing.Point(116, 208);
            this.nu_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.nu_fiyat.Name = "nu_fiyat";
            this.nu_fiyat.Size = new System.Drawing.Size(268, 22);
            this.nu_fiyat.TabIndex = 7;
            // 
            // nu_GuvenlikStok
            // 
            this.nu_GuvenlikStok.Location = new System.Drawing.Point(116, 243);
            this.nu_GuvenlikStok.Margin = new System.Windows.Forms.Padding(4);
            this.nu_GuvenlikStok.Name = "nu_GuvenlikStok";
            this.nu_GuvenlikStok.Size = new System.Drawing.Size(268, 22);
            this.nu_GuvenlikStok.TabIndex = 7;
            // 
            // tb_urunAdi
            // 
            this.tb_urunAdi.Location = new System.Drawing.Point(105, 174);
            this.tb_urunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_urunAdi.Name = "tb_urunAdi";
            this.tb_urunAdi.Size = new System.Drawing.Size(279, 22);
            this.tb_urunAdi.TabIndex = 6;
            // 
            // tb_barkod
            // 
            this.tb_barkod.Location = new System.Drawing.Point(105, 141);
            this.tb_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(279, 22);
            this.tb_barkod.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Güvenlik Stoğu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tedarikçi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barkod No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori:";
            // 
            // cb_Tedarikci
            // 
            this.cb_Tedarikci.FormattingEnabled = true;
            this.cb_Tedarikci.Location = new System.Drawing.Point(105, 107);
            this.cb_Tedarikci.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Tedarikci.Name = "cb_Tedarikci";
            this.cb_Tedarikci.Size = new System.Drawing.Size(279, 24);
            this.cb_Tedarikci.TabIndex = 2;
            this.cb_Tedarikci.Text = "Seçiniz...";
            // 
            // cb_marka
            // 
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(105, 74);
            this.cb_marka.Margin = new System.Windows.Forms.Padding(4);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(279, 24);
            this.cb_marka.TabIndex = 1;
            this.cb_marka.Text = "Seçiniz...";
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Items.AddRange(new object[] {
            "Seçiniz..."});
            this.cb_kategori.Location = new System.Drawing.Point(105, 41);
            this.cb_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(279, 24);
            this.cb_kategori.TabIndex = 0;
            this.cb_kategori.Text = "Seçiniz...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 300);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 210);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_guncelle,
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // TSMI_guncelle
            // 
            this.TSMI_guncelle.Name = "TSMI_guncelle";
            this.TSMI_guncelle.Size = new System.Drawing.Size(135, 24);
            this.TSMI_guncelle.Text = "Güncelle";
            this.TSMI_guncelle.Click += new System.EventHandler(this.TSMI_guncelle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(135, 24);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunIslemleri";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ürün İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_GuvenlikStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Tedarikci;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_urunAdi;
        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nu_fiyat;
        private System.Windows.Forms.NumericUpDown nu_GuvenlikStok;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_hizli;
        private System.Windows.Forms.CheckBox cb_aktif;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ted_ekle;
        private System.Windows.Forms.Button btn_marka_ekle;
        private System.Windows.Forms.Button btn_kat_ekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
    }
}