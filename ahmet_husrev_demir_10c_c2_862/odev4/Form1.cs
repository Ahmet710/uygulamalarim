using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool ogrenciNoAyniMi(string ogrNo)
        {           

            for(int i = 0; i < liste.Items.Count; i++)
            {
                if (liste.Items[i].SubItems[0].Text == ogrNo)
                {
                    MessageBox.Show("Aynı Nolu öğrenci zaten bulunmaktadır...","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return true;
                }
            }

            return false;
        }

        private void verileritemizle()
        {
            txt_isim.Text = "";
            txt_ogrenciNo.Text = "";
            txt_tcNo.Text = "";
            cbox_cinsiyet.SelectedIndex = -1;
            date_dogumTarihi.Value = DateTime.Now; 
        }

        private void btn_ogrenci_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_isim.Text) || string.IsNullOrEmpty(txt_tcNo.Text) || string.IsNullOrEmpty(txt_ogrenciNo.Text) || cbox_cinsiyet.SelectedIndex == -1 || string.IsNullOrEmpty(date_dogumTarihi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }

            else if(txt_tcNo.Text.Length!=11)
            {
                MessageBox.Show("Lütfen T.C. numaranızı doğru giriniz");
            }

            else
            {

                ogrencikayit ogr = new ogrencikayit();

                ogr.tcno = txt_tcNo.Text.Trim();
                ogr.no = txt_ogrenciNo.Text.Trim();
                ogr.dogumtarihi = date_dogumTarihi.Text.ToString();
                ogr.cinsiyet = cbox_cinsiyet.Text.ToString();
                ogr.adsoyad = txt_isim.Text.Trim().ToString();

                if(!ogrenciNoAyniMi(ogr.no))
                {
                    string[] ogrenci_bilgileri = { ogr.No, ogr.adsoyad, ogr.cinsiyet, ogr.dogumtarihi, ogr.TcNoGonder() };

                    ListViewItem item = new ListViewItem(ogrenci_bilgileri);

                    liste.Items.Add(item);
                    verileritemizle();

                    MessageBox.Show("Öğrenci kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Öğrenci kaydedilemedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_tumKayitSil_Click_1(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Son kararınız mı ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (soru == DialogResult.OK)
            {
                liste.Items.Clear();
                MessageBox.Show("Bütün Öğeler Silindi!", "Dikkat", MessageBoxButtons.OK);
            }
        }



        private void btn_OgrenciNoSirala_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < liste.Items.Count - 1; i++)
            {
                for (int j = i + 1; j < liste.Items.Count; j++)
                {
                    int numara1 = Convert.ToInt32(liste.Items[i].SubItems[0].Text);
                    int numara2 = Convert.ToInt32(liste.Items[j].SubItems[0].Text);

                    if (numara1 < numara2)
                    {
                        string yedekNumara = liste.Items[i].SubItems[0].Text;
                        string yedekAd = liste.Items[i].SubItems[1].Text;

                        liste.Items[i].SubItems[0].Text = liste.Items[j].SubItems[0].Text;
                        liste.Items[i].SubItems[1].Text = liste.Items[j].SubItems[1].Text;

                        liste.Items[j].SubItems[0].Text = yedekNumara;
                        liste.Items[j].SubItems[1].Text = yedekAd;
                    }
                }
            }
        }



        private void btn_tumKayitSil_Click(object sender, EventArgs e)
        {
            DialogResult soru =  MessageBox.Show("Tüm bilgileri silmek sitediğinizden emin misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(DialogResult.Yes == soru)
            {
                liste.Items.Clear();
                MessageBox.Show("Bilgiler başaıyla silindi...","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void btn_SeciliSil_Click(object sender, EventArgs e)
        {
            if (liste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            liste.Items.Remove(liste.SelectedItems[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Çıkmak istediğinize emin misiniz ?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(DialogResult.Yes == soru)
            {
                this.Close();
            }
        }
    }
}
