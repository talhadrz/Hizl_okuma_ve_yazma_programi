using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace oku_Yaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kelime[0] = db.Meslekler.Count();
            kelime[1] = db.Hayvanlar.Count();
            kelime[2] = db.Teknoloji.Count();
            kelime[3] = db.Esyalar.Count();
            kelime[4] = db.Kelimeler_D.Count(); 
        }
        List<Teknoloji> Teknoloji;
        List<Hayvanlar> Hayvanlar;
        List<Esyalar> Esyalar;
        List<Meslekler> Meslekler;
        List<Kelimeler_D> Kelimeler_D;
        Random rnd = new Random();
        KelimelerEntities1 db = new KelimelerEntities1();
        int[] kelime = new int[5];
        public string name, mtn;
        bool ac = true;
        int id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            txtKelime.Enabled = true;
            do
            {
                int s1 = rnd.Next(0, 5);
                int s2 = rnd.Next(1, kelime[s1]);
                switch (s1)
                {
                    case 0:
                        mtn = Meslekler.Where(x => x.MeslekId == s2).Select(y => y.Meslekler1).FirstOrDefault();
                        break;
                    case 1:
                        mtn = Hayvanlar.Where(x => x.HayvanId == s2).Select(y => y.Hayvanlar1).FirstOrDefault();
                        break;
                    case 2:
                        mtn = Teknoloji.Where(x => x.TeknolojiId == s2).Select(y => y.Teknolojilr).FirstOrDefault();
                        break;
                    case 3:
                        mtn = Esyalar.Where(x => x.EsyalarId == s2).Select(y => y.Esyalar1).FirstOrDefault();
                        break;
                    case 4:
                        mtn = Kelimeler_D.Where(x => x.Kelimeler_DId == s2).Select(y => y.Kelimeler_D1).FirstOrDefault();
                        break;
                }
            } while (mtn == null);
            yaz(mtn);
        }
        public async void yaz(string mtn2)
        {
            txtKelime.Text = mtn2;
            int time = mtn2.Length < 5 ? 100 : mtn2.Length < 10 ? 300 : 500;
            await Task.Delay(time);
            txtKelime.Text = null;
        }

        private void lblCık_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            Giris_Sayfası frm = new Giris_Sayfası();
            frm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            id = db.WordCounts.Where(x => x.Name == name).Select(y => y.ID).FirstOrDefault();
            lblmax.Text = db.WordCounts.Where(x => x.Name == name).Select(y => y.WordCount1).FirstOrDefault().ToString();
            txtKelime.Enabled = false; Teknoloji = db.Teknoloji.ToList();
            Hayvanlar = db.Hayvanlar.ToList();
            Esyalar = db.Esyalar.ToList();
            Meslekler = db.Meslekler.ToList();
            Kelimeler_D = db.Kelimeler_D.ToList();
        }

        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (txtKelime.Text == mtn & ac)
                {
                    button1_Click(sender, e);
                    var value = db.WordCounts.Find(id);
                    value.WordCount1 = int.Parse(lblmax.Text) + 1;
                    db.SaveChanges();
                    lblmax.Text = db.WordCounts.Where(x => x.Name == name).Select(y => y.WordCount1).FirstOrDefault().ToString();
                    lblnow.Text = (int.Parse(lblnow.Text) + 1).ToString();
                }
                else
                {
                    yaz(mtn);
                }
            }
            ac = false;
            await Task.Delay(600);
            ac = true;
        }
    }
}