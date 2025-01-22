using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oku_Yaz
{
    public partial class Giris_Sayfası : Form
    {
        public Giris_Sayfası()
        {
            InitializeComponent();
        }
        KelimelerEntities1 db = new KelimelerEntities1();
        private void Giris_Sayfası_Load(object sender, EventArgs e)
        {
            var values = db.WordCounts.Select(x => new
            {
                FullName = x.Name,
                x.ID
            }).ToList();
            cmbName.DisplayMember = "FullName";
            cmbName.ValueMember = "Guideıd";
            cmbName.DataSource = values;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (kontrol(cmbName.Text, txtPassword.Text))
            {
                Form1 frm = new Form1();
                frm.name = cmbName.Text;
                frm.Show();
                this.Hide();
            }
        }
        private bool kontrol(string isim, string sifre)
        {
            bool esitmi = db.WordCounts.Any(x => x.Name == isim && x.password == sifre);
            if (esitmi)
                return true;
            else
            {
                MessageBox.Show("Ad Veya Şifre Kısmında Bir Hata Bulunmaktadır Lütfen Tekrar Deneyiniz");
                return false;
            }
        }
        private void Kayıt_Guncelle(string frmtext, string btntext)
        {
            Kayıt_Güncelle_Sayfası frm = new Kayıt_Güncelle_Sayfası();
            frm.btnKayıt.Text = btntext;
            frm.Text = frmtext;
            if (btntext == "Güncelle")
            {
                frm.txtName.Text = cmbName.Text;
                frm.txtPassword.Text = txtPassword.Text;
                var id = db.WordCounts.Where(x => x.Name == cmbName.Text).Select(x => x.ID).FirstOrDefault();
                frm.id = id;
            }
            frm.Show();
            this.Hide();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (kontrol(cmbName.Text, txtPassword.Text))
            {
                DialogResult result = MessageBox.Show("Verileriniz silinecek. Devam etmek istiyor musunuz?", "Onay Kutusu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var value = db.WordCounts.Where(x => x.Name == cmbName.Text).FirstOrDefault();
                    db.WordCounts.Remove(value);
                    db.SaveChanges();
                    Giris_Sayfası_Load(sender, e);
                    MessageBox.Show("Değer Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("İşlem İptal Edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (kontrol(cmbName.Text, txtPassword.Text))
            {
                Kayıt_Guncelle("Güncelleme Formu", "Güncelle");
            }
        }

        private void lblKayıtFormu_Click(object sender, EventArgs e)
        {
            Kayıt_Guncelle("Kayıt Formu", "Kaydet");
        }
    }
}
