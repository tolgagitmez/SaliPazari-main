﻿namespace SaliPazariWinformsApp
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_kullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_KategoriForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Markalar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciForm = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_kullanici});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_kullanici
            // 
            this.TSSL_kullanici.Name = "TSSL_kullanici";
            this.TSSL_kullanici.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.urunİşlemleriToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.kapatToolStripMenuItem.Text = "Kapat";
            // 
            // urunİşlemleriToolStripMenuItem
            // 
            this.urunİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_KategoriForm,
            this.TSMI_Markalar,
            this.TSMI_UrunForm,
            this.TSMI_TedarikciForm});
            this.urunİşlemleriToolStripMenuItem.Name = "urunİşlemleriToolStripMenuItem";
            this.urunİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.urunİşlemleriToolStripMenuItem.Text = "Urun İşlemleri";
            // 
            // TSMI_KategoriForm
            // 
            this.TSMI_KategoriForm.Name = "TSMI_KategoriForm";
            this.TSMI_KategoriForm.Size = new System.Drawing.Size(224, 26);
            this.TSMI_KategoriForm.Text = "Kategoriler";
            this.TSMI_KategoriForm.Click += new System.EventHandler(this.TSMI_KategoriForm_Click);
            // 
            // TSMI_Markalar
            // 
            this.TSMI_Markalar.Name = "TSMI_Markalar";
            this.TSMI_Markalar.Size = new System.Drawing.Size(224, 26);
            this.TSMI_Markalar.Text = "Markalar";
            this.TSMI_Markalar.Click += new System.EventHandler(this.TSMI_Markalar_Click);
            // 
            // TSMI_UrunForm
            // 
            this.TSMI_UrunForm.Name = "TSMI_UrunForm";
            this.TSMI_UrunForm.Size = new System.Drawing.Size(224, 26);
            this.TSMI_UrunForm.Text = "Ürünler";
            this.TSMI_UrunForm.Click += new System.EventHandler(this.TSMI_UrunForm_Click);
            // 
            // TSMI_TedarikciForm
            // 
            this.TSMI_TedarikciForm.Name = "TSMI_TedarikciForm";
            this.TSMI_TedarikciForm.Size = new System.Drawing.Size(224, 26);
            this.TSMI_TedarikciForm.Text = "Tedarikçiler";
            this.TSMI_TedarikciForm.Click += new System.EventHandler(this.TSMI_TedarikciForm_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.Text = "Salı Pazarı App";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_kullanici;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Markalar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciForm;
    }
}