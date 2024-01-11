using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaliPazariWinformsApp
{
    public partial class HızlıTedarikciEkle : Form
    {
        SaliPazari_DBEntities db = new SaliPazari_DBEntities();
        public HızlıTedarikciEkle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Tedarikciler ted = new Tedarikciler();
            ted.FirmaIsim = tb_ekle.Text;
            ted.TicariUnvan = ted.Sorumlu = ted.Adres = ted.MailAdresi = "";
            ted.Telefon = null;
            ted.IsActive = IsActive.Checked;
            ted.IsDeleted = false;
            db.Tedarikcilers.Add(ted);
            db.SaveChanges();
            MessageBox.Show("Tedarikçi Eklendi");
            
        }
    }
}
