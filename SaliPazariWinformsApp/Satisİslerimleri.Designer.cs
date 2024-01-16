namespace SaliPazariWinformsApp
{
    partial class Satisİslerimleri
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
            this.dtp_satis = new System.Windows.Forms.DateTimePicker();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tb_faturano = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nu_fiyat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nu_adet = new System.Windows.Forms.NumericUpDown();
            this.cb_yetkili = new System.Windows.Forms.ComboBox();
            this.cb_urun = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvsatis = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsatis)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtp_satis);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.tb_faturano);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nu_fiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nu_adet);
            this.groupBox1.Controls.Add(this.cb_yetkili);
            this.groupBox1.Controls.Add(this.cb_urun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İşlerimleri";
            // 
            // dtp_satis
            // 
            this.dtp_satis.Location = new System.Drawing.Point(347, 112);
            this.dtp_satis.Name = "dtp_satis";
            this.dtp_satis.Size = new System.Drawing.Size(248, 22);
            this.dtp_satis.TabIndex = 16;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(610, 21);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(98, 23);
            this.btn_temizle.TabIndex = 15;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(610, 50);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(98, 23);
            this.btn_guncelle.TabIndex = 14;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(610, 79);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(98, 23);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(610, 50);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(98, 23);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tb_faturano
            // 
            this.tb_faturano.Location = new System.Drawing.Point(127, 109);
            this.tb_faturano.Name = "tb_faturano";
            this.tb_faturano.Size = new System.Drawing.Size(155, 22);
            this.tb_faturano.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fatura No:";
            // 
            // nu_fiyat
            // 
            this.nu_fiyat.DecimalPlaces = 2;
            this.nu_fiyat.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nu_fiyat.Location = new System.Drawing.Point(416, 70);
            this.nu_fiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nu_fiyat.Name = "nu_fiyat";
            this.nu_fiyat.Size = new System.Drawing.Size(154, 22);
            this.nu_fiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat";
            // 
            // nu_adet
            // 
            this.nu_adet.Location = new System.Drawing.Point(416, 32);
            this.nu_adet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nu_adet.Name = "nu_adet";
            this.nu_adet.Size = new System.Drawing.Size(154, 22);
            this.nu_adet.TabIndex = 7;
            // 
            // cb_yetkili
            // 
            this.cb_yetkili.FormattingEnabled = true;
            this.cb_yetkili.Location = new System.Drawing.Point(127, 67);
            this.cb_yetkili.Name = "cb_yetkili";
            this.cb_yetkili.Size = new System.Drawing.Size(155, 24);
            this.cb_yetkili.TabIndex = 6;
            // 
            // cb_urun
            // 
            this.cb_urun.FormattingEnabled = true;
            this.cb_urun.Location = new System.Drawing.Point(127, 26);
            this.cb_urun.Name = "cb_urun";
            this.cb_urun.Size = new System.Drawing.Size(155, 24);
            this.cb_urun.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetkili:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün:";
            // 
            // dgvsatis
            // 
            this.dgvsatis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsatis.Location = new System.Drawing.Point(12, 215);
            this.dgvsatis.Name = "dgvsatis";
            this.dgvsatis.RowHeadersWidth = 51;
            this.dgvsatis.RowTemplate.Height = 24;
            this.dgvsatis.Size = new System.Drawing.Size(897, 233);
            this.dgvsatis.TabIndex = 1;
            this.dgvsatis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvsatis_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_guncelle,
            this.TSMI_Sil});
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
            // TSMI_Sil
            // 
            this.TSMI_Sil.Name = "TSMI_Sil";
            this.TSMI_Sil.Size = new System.Drawing.Size(135, 24);
            this.TSMI_Sil.Text = "Sil";
            this.TSMI_Sil.Click += new System.EventHandler(this.TSMI_Sil_Click);
            // 
            // Satisİslerimleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.dgvsatis);
            this.Controls.Add(this.groupBox1);
            this.Name = "Satisİslerimleri";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Satisİslerimleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Satisİslerimleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsatis)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvsatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_yetkili;
        private System.Windows.Forms.ComboBox cb_urun;
        private System.Windows.Forms.NumericUpDown nu_adet;
        private System.Windows.Forms.NumericUpDown nu_fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_faturano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.DateTimePicker dtp_satis;
    }
}