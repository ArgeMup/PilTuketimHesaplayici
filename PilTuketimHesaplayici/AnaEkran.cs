using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArgeMup.HazirKod;

namespace PilTuketimHesaplayici
{
    public partial class AnaEkran : Form
    {
        Ayarlar_ Ayarlar;
        List<Depo.Biri> İşler;
        double ToplamTüketim = 0;

        public AnaEkran()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Ayarlar = new Ayarlar_(out bool sonuç);

            İşler = Ayarlar.Listele_AltDal(Ayarlar.Oku("İşler"));
            foreach (var biri in İşler)
            {
                Liste_İşler.Items.Add(biri.Adı);
            }
            if (Liste_İşler.Items.Count > 0) Liste_İşler.SelectedIndex = 0;
        }

        private void Liste_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int Y = e.RowIndex, X = e.ColumnIndex;
            double akım_A = 0, etkin_süre_sa = 0, durgun_süre_sa = 0;
            string gecici;

            if (X < 0 || Y < 0 || X > 2) return;
            Liste[3, Y].Tag = null;

            for (X = 0; X < 3; X++)
            {
                Liste[X, Y].ErrorText = "";
                gecici = (string)Liste[X, Y].Value;
                bool sonuç = false;

                switch (X)
                {
                    case (0):
                        sonuç = MetniAyıkla_Amper(ref gecici, out akım_A);
                        break;

                    case (1):
                        sonuç = MetniAyıkla_Saat(ref gecici, out etkin_süre_sa);
                        break;

                    case (2):
                        sonuç = MetniAyıkla_Saat(ref gecici, out durgun_süre_sa);
                        break;
                }

                if (!sonuç) { Liste[X, Y].ErrorText = "Hatalı yazım"; return; }

                Liste[X, Y].Value = gecici;
            }

            double tüketim = akım_A * (etkin_süre_sa / (etkin_süre_sa + durgun_süre_sa));

            Liste[3, Y].Tag = tüketim;
            Liste[3, Y].Value = MetniOluştur_Akım(tüketim);

            //Toplam tüketimin hesaplanması
            ToplamTüketim = 0;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if (Liste[3, i].Tag != null && Liste[3, i].Tag.GetType() == typeof(double))
                {
                    ToplamTüketim += (double)Liste[3, i].Tag;
                }
            }
            HesaplamaSonucu_tüketim.Text = MetniOluştur_Akım(ToplamTüketim);

            PilKapasitesi_TextChanged(null, null);
        }
        private void Liste_İşler_TextChanged(object sender, EventArgs e)
        {
            foreach (var biri in İşler)
            {
                if (Liste_İşler.Text == biri.Adı)
                {
                    EkleGüncelle.Text = "Güncelle";
                    return;
                }
            }

            EkleGüncelle.Text = "Ekle";
        }
        private void Liste_İşler_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var iş in İşler)
            {
                if (iş.Adı == Liste_İşler.Text)
                {
                    List<Depo.Biri> Satırlar = Ayarlar.Listele_AltDal(iş.İçeriği);

                    Liste.Rows.Clear();
                    Liste.RowCount = Satırlar.Count + 1;

                    for (int i = 0; i < Satırlar.Count; i++)
                    {
                        Liste[0, i].Value = Ayarlar.Oku_AltDal(Satırlar[i].İçeriği, "Akım");
                        Liste[1, i].Value = Ayarlar.Oku_AltDal(Satırlar[i].İçeriği, "Etkin");
                        Liste[2, i].Value = Ayarlar.Oku_AltDal(Satırlar[i].İçeriği, "Durgun");
                        Liste[3, i].Tag = Convert.ToDouble(Ayarlar.Oku_AltDal(Satırlar[i].İçeriği, "Tüketim"));
                        Liste[3, i].Value = MetniOluştur_Akım((double)Liste[3, i].Tag);
                        Liste[4, i].Value = Ayarlar.Oku_AltDal(Satırlar[i].İçeriği, "Açıklama");
                    }

                    return;
                }
            }
        }

        bool MetniAyıkla_Saat(ref string Girdi, out double Çıktı)
        {
            Çıktı = 0;
            string birim;
            if (string.IsNullOrEmpty(Girdi)) return false;
            Girdi = Girdi.Trim().ToLower();

            //Süre sa dk sn msn usn nsn
            if (Girdi.Contains("nsn")) { Çıktı = 60 * 60 * 1E9; Girdi = Girdi.Replace("nsn", ""); birim = " nsn"; }
            else if (Girdi.Contains("usn")) { Çıktı = 60 * 60 * 1E6; Girdi = Girdi.Replace("usn", ""); birim = " usn"; }
            else if (Girdi.Contains("msn")) { Çıktı = 60 * 60 * 1E3; Girdi = Girdi.Replace("msn", ""); birim = " msn"; }
            else if (Girdi.Contains("sn")) { Çıktı = 60 * 60; Girdi = Girdi.Replace("sn", ""); birim = " sn"; }
            else if (Girdi.Contains("dk")) { Çıktı = 60; Girdi = Girdi.Replace("dk", ""); birim = " dk"; }
            else if (Girdi.Contains("sa")) { Çıktı = 1; Girdi = Girdi.Replace("sa", ""); birim = " sa"; }
            else return false;

            if (!double.TryParse(Girdi, out double Sayısal)) return false;

            Girdi = Sayısal.ToString() + birim;
            Çıktı = Sayısal / Çıktı;
            return true;
        }
        bool MetniAyıkla_Amper(ref string Girdi, out double Çıktı)
        {
            Çıktı = 0;
            string birim;
            if (string.IsNullOrEmpty(Girdi)) return false;
            Girdi = Girdi.Trim().ToLower();
            
            //Akım A mA uA nA
            if (Girdi.Contains("na")) { Çıktı = 1E9; Girdi = Girdi.Replace("na", ""); birim = " nA"; }
            else if (Girdi.Contains("ua")) { Çıktı = 1E6; Girdi = Girdi.Replace("ua", ""); birim = " uA"; }
            else if (Girdi.Contains("ma")) { Çıktı = 1E3; Girdi = Girdi.Replace("ma", ""); birim = " mA"; }
            else if (Girdi.Contains("a")) { Çıktı = 1; Girdi = Girdi.Replace("a", ""); birim = " A"; }
            else return false;

            if (!double.TryParse(Girdi, out double Sayısal)) return false;

            Girdi = Sayısal.ToString() + birim;
            Çıktı = Sayısal / Çıktı;
            return true;
        }
        string MetniOluştur_Akım(double Girdi)
        {
            if (Girdi >= 1) return Girdi.ToString() + " A Saat";
            else if (Girdi >= 1E-3) return (Girdi / 1E-3).ToString() + " mA Saat";
            else if (Girdi >= 1E-6) return (Girdi / 1E-6).ToString() + " uA Saat";
            else return (Girdi / 1E-9).ToString() + " nA Saat";
        }

        private void EkleGüncelle_Click(object sender, EventArgs e)
        {
            string Tablo = "";

            for (int i = 0; i < Liste.RowCount; i++)
            {
                if (Liste[3, i].Tag == null) Liste[3, i].Tag = (double)0;

                try
                {
                    string Satır = "";
                    Ayarlar.Yaz_AltDal(ref Satır, "Akım", Liste[0, i].Value.ToString());
                    Ayarlar.Yaz_AltDal(ref Satır, "Etkin", Liste[1, i].Value.ToString());
                    Ayarlar.Yaz_AltDal(ref Satır, "Durgun", Liste[2, i].Value.ToString());
                    Ayarlar.Yaz_AltDal(ref Satır, "Tüketim", ((double)(Liste[3, i].Tag)).ToString());
                    Ayarlar.Yaz_AltDal(ref Satır, "Açıklama", Liste[4, i].Value.ToString());

                    Ayarlar.Yaz_AltDal(ref Tablo, i.ToString(), Satır);
                }
                catch (Exception) { }
            }

            İşler.Add(new Depo.Biri(Liste_İşler.Text, Tablo));

            string xml = "";
            Ayarlar.ListeyiEkle_AltDal(ref xml, İşler);
            Ayarlar.Yaz("İşler", xml);
            İşler = Ayarlar.Listele_AltDal(Ayarlar.Oku("İşler"));
        }

        private void PilKapasitesi_TextChanged(object sender, EventArgs e)
        {
            //Toplam pil kapasitesinin bulunması
            string gecici = PilKapasitesi.Text;
            if (!MetniAyıkla_Amper(ref gecici, out double PilKapasite)) { PilKapasitesi.ForeColor = Color.Red; return; }
            PilKapasitesi.ForeColor = Color.Black;
            PilKapasitesi.Text = gecici;

            //Pil Veriminin hesaplanması
            if (!double.TryParse(PilVerimliliği.Text, out double PilVerim)) { PilVerimliliği.ForeColor = Color.Red; return; }
            PilVerimliliği.ForeColor = Color.Black;

            //Kullanılabilir kapasite
            double KullanılabilirKapasite = PilKapasite / 100 * PilVerim;

            //Kullanılabilir süre
            HesaplamaSonucu_süre.Text = ArgeMup.HazirKod.Dönüştürme.D_Süre.Metne.Saatten((int)(KullanılabilirKapasite / ToplamTüketim)).Replace("dk. dan", "sa. dan"); ;
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            string a = string.Format("mailto:{0}?Subject={1}&Body={2}", "mup.arge@gmail.com", "Pil Tüketimi Hesaplayıcı Hk.", "Mesajınız");
            System.Diagnostics.Process.Start(a);
        }
        private void Menu_aA_100_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 8);
        }
        private void Menu_aA_125_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 10);
        }
        private void Menu_aA_150_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 12);
        }
        private void Menu_aA_175_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 14);
        }
        private void Menu_aA_200_Click(object sender, EventArgs e)
        {
            Font = new System.Drawing.Font(Font.FontFamily, 16);
        }
    }
}