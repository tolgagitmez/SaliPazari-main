using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace SaliPazariWinformsApp
{
    public partial class Satisİslerimleri : Form
    {
        SaliPazari_DBEntities db = new SaliPazari_DBEntities();
        DataModel dm = new DataModel();
        
        int satisdetayID;
        int satisid;
        public Satisİslerimleri()
        {
            InitializeComponent();
            GridDoldur();

        }

        private void Satisİslerimleri_Load(object sender, EventArgs e)
        {
            cb_urun.ValueMember = "ID";
            cb_urun.DisplayMember = "UrunAdi";
            cb_urun.DataSource = db.Urunlers.ToList();
            cb_urun.Text = "Seçiniz...";
            
            cb_yetkili.ValueMember = "ID";
            cb_yetkili.DisplayMember = "Isim";
            cb_yetkili.DataSource = db.Yoneticilers.ToList();
            cb_yetkili.Text = "Seçiniz...";

            dtp_satis.Visible = false;
            GridDoldur();
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SatisDetaylar sd = new SatisDetaylar();
            Satislar s = new Satislar();
            sd.Urun_ID = Convert.ToInt32(cb_urun.SelectedValue);
            s.Kasiyer_ID = Convert.ToInt32(cb_yetkili.SelectedValue);
            s.FaturaNo = tb_faturano.Text;
            sd.Adet = Convert.ToInt32(nu_adet.Value);
            sd.Fiyat = Convert.ToInt32(nu_fiyat.Value);
            s.Tarih = DateTime.Now;
            sd.Satis_ID = s.ID;

            try
            {
                db.SatisDetaylars.Add(sd);
                db.Satislars.Add(s);
                db.SaveChanges();
                GridDoldur();
                Temizle();
                MessageBox.Show($"Satış {sd.Satislar.ID} id ile eklenmiştir");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
        public void GridDoldur()
        {
            dgvsatis.Rows.Clear();
            dgvsatis.ColumnCount = 9;
            dgvsatis.Columns[0].Name = "ID";
            dgvsatis.Columns[0].Width = 30;
            dgvsatis.Columns[1].Name = "Ürün";
            dgvsatis.Columns[1].Width = 100;
            dgvsatis.Columns[2].Name = "Yetkili";
            dgvsatis.Columns[2].Width = 60;
            dgvsatis.Columns[3].Name = "Fatura No";
            dgvsatis.Columns[3].Width = 100;
            dgvsatis.Columns[4].Name = "Tarih";
            dgvsatis.Columns[4].Width = 120;
            dgvsatis.Columns[5].Name = "Satış Adet";
            dgvsatis.Columns[5].Width = 50;
            dgvsatis.Columns[6].Name = "Fiyat";
            dgvsatis.Columns[6].Width = 50;
            dgvsatis.Columns[7].Name = "Stok Miktarı";
            dgvsatis.Columns[7].Width = 60;
            dgvsatis.Columns[8].Name = "Toplam Gelir";
            dgvsatis.Columns[8].Width = 80;



            List<SatisDetaylarAdo> s = dm.SatisListele();
            foreach (SatisDetaylarAdo item in s)
            {
                ArrayList row = new ArrayList();
                row.Add(item.ID);
                row.Add(item.UrunAdi);
                row.Add(item.Yonetici);
                row.Add(item.BarkodNo);
                row.Add(item.Tarih);
                row.Add(item.Adet);
                row.Add(item.Fiyat + "₺");
                row.Add(item.StokMiktari);
                row.Add(item.Adet * item.Fiyat + "₺");

                dgvsatis.Rows.Add(row.ToArray());
            }
        }

        private void dgvsatis_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int tiklananSatir = dgvsatis.HitTest(e.X, e.Y).RowIndex;
                if (tiklananSatir != -1)
                {
                    contextMenuStrip1.Show(dgvsatis, new Point(e.X, e.Y));
                    dgvsatis.ClearSelection();
                    dgvsatis.Rows[tiklananSatir].Selected = true;
                    satisdetayID = Convert.ToInt32(dgvsatis.Rows[tiklananSatir].Cells[0].Value);

                }
            }
        }

        private void TSMI_guncelle_Click(object sender, EventArgs e)
        {
            SatisDetaylar sd = db.SatisDetaylars.Find(satisdetayID);
            if (sd != null)
            {
                cb_urun.SelectedValue = sd.Urunler.ID;
                cb_yetkili.SelectedValue = sd.Satislar.Yoneticiler.ID;
                tb_faturano.Text = sd.Satislar.FaturaNo;
                nu_adet.Value = sd.Adet.Value;
                nu_fiyat.Value = sd.Fiyat.Value;
                satisid = sd.Satislar.ID;
                dtp_satis.Visible = true;
                btn_ekle.Visible = false;
                btn_guncelle.Visible = true;
            }
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            SatisDetaylar sd = db.SatisDetaylars.Find(satisdetayID);
            satisid = sd.Satislar.ID;
            Satislar s = db.Satislars.Find(satisid);



            if (MessageBox.Show(satisdetayID + " ID'li Satış Silinecektir. Devam etmek istiyor musunuz?", "Veri Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                db.SatisDetaylars.Remove(sd);
                db.Satislars.Remove(s);
                db.SaveChanges();


                GridDoldur();
                MessageBox.Show(satisdetayID + " ID'li Ürün Silinmiştir", "Başarılı");

            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi", "Bilgi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cb_urun.SelectedValue.ToString()))
            {
                SatisDetaylar sd = db.SatisDetaylars.Find(satisdetayID);
                Satislar s = db.Satislars.Find(satisid);

                sd.Urun_ID = Convert.ToInt32(cb_urun.SelectedValue);
                s.Kasiyer_ID = Convert.ToInt32(cb_yetkili.SelectedValue);
                s.FaturaNo = tb_faturano.Text;
                sd.Adet = Convert.ToInt32(nu_adet.Value);
                sd.Fiyat = Convert.ToInt32(nu_fiyat.Value);
                s.Tarih = dtp_satis.Value;
                sd.Satis_ID = s.ID;



                db.SatisDetaylars.AddOrUpdate(sd);
                db.Satislars.AddOrUpdate(s);
                db.SaveChanges();
                Temizle();
                GridDoldur();
                MessageBox.Show(satisdetayID + " ID'li Satış Güncellendi", "Başarılı");
            }
            else
            {
                MessageBox.Show("Ürün adı boş bırakılmamalıdır", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Temizle()
        {
            cb_urun.DataSource = db.Urunlers.ToList();
            cb_urun.Text = "Seçiniz...";
            
            cb_yetkili.DataSource = db.Yoneticilers.ToList();
            cb_yetkili.Text = "Seçiniz...";

            tb_faturano.Text = "";
            nu_adet.Value = 0;
            nu_fiyat.Value = 0;
            dtp_satis.Visible = false;
            btn_guncelle.Visible = false;
            btn_ekle.Visible = true;
            GridDoldur();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


    }
}
