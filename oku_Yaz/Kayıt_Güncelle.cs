using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oku_Yaz
{
    public partial class Kayıt_Güncelle_Sayfası : Form
    {
        public Kayıt_Güncelle_Sayfası()
        {
            InitializeComponent();
        }
        KelimelerEntities1 db = new KelimelerEntities1();
        public int id;
        private void lblGirs_Click(object sender, EventArgs e)
        {
            Giris_Sayfası frm = new Giris_Sayfası();
            frm.Show();
            this.Hide();
        }
        void kaydet()
        {
            if (txtName != null & db.WordCounts.Any(x => x.Name != txtName.Text)) 
            {
                if (txtPassword.Text.Length > 3)
                {
                    WordCount yks = new WordCount();
                    yks.Name = txtName.Text;
                    yks.password = txtPassword.Text;
                    yks.WordCount1 = 0;
                    db.WordCounts.Add(yks);
                }
                else
                    MessageBox.Show("Şifre 4 karakterden az olamaz lütfen tekrar deneyiniz");
            }
            else
                MessageBox.Show("Bu isim ya kullanılıyor yada eksik bıraktınız lütfen tekrar deneyiniz");

        }
        void guncelle()
        {
            if (txtName != null)
            {
                if (txtPassword.Text.Length > 3)
                {
                    var values = db.WordCounts.Find(id);
                    values.Name = txtName.Text;
                    values.password = txtPassword.Text;
                }
                else
                    MessageBox.Show("Şifre 4 karakterden az olamaz lütfen tekrar deneyiniz");
            }
            else
                MessageBox.Show("isim kısmını eksik bıraktınız lütfen tekrar deneyiniz");
        }
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (btnKayıt.Text == "Güncelle")
            {
                guncelle();
            }
            else if (btnKayıt.Text == "Kaydet")
            {
                kaydet();
            }
            db.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
            lblGirs_Click(sender, e);
        }
    }
}
