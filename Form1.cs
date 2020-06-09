using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SifreOlusturma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifre_uret_Click(object sender, EventArgs e)
        {
            txt_sifre.Text = "";
            string sifre = "";
            int rnd = 0;

            Random rnd_kh = new Random();
            Random rnd_bh = new Random();
            Random rnd_rk = new Random();

            for (int i = 0; i < Convert.ToInt16(txt_b_harf_sayisi.Text); i++)
            {
                rnd = rnd_bh.Next(0, txt_buyuk_harfler.Text.Length - 1);
                txt_sifre.Text += txt_buyuk_harfler.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(txt_k_harf_sayisi.Text); i++)
            {
                rnd = rnd_kh.Next(0, txt_kucuk_harfler.Text.Length - 1);
                txt_sifre.Text += txt_kucuk_harfler.Text[rnd];
            }
            for (int i = 0; i < Convert.ToInt16(txt_rakam_sayisi.Text); i++)
            {
                rnd = rnd_rk.Next(0, txt_rakamlar.Text.Length - 1);
                txt_sifre.Text += txt_rakamlar.Text[rnd];
            }

            Random rnd_karistir = new Random();
            sifre = txt_sifre.Text;
            txt_sifre.Text = new string(sifre.ToCharArray().OrderBy(s => (rnd_karistir.Next(2) % 2) == 0).ToArray());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
