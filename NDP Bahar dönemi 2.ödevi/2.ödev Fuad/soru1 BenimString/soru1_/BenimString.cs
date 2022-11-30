/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2 
**				ÖĞRENCİ ADI............: Fuad Garibli   
**				ÖĞRENCİ NUMARASI.......: G201210558
**              DERSİN ALINDIĞI GRUP...: 2.öğretim C grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace soru1_
{
    class BenimString
    {
        private string sonuc_dondur;
        private int sayac = 0;
        private int baslangic = 0;
        private int ilk_sayac = 0;

        public int ElemanSayısı(string string_1)
        {
            sayac = 0;
            foreach (char ch in string_1)
            {
                sayac++;//karakterler sayılır
            }
            return sayac;
        }
        public string Birlestir(string string_1, string string_2)
        {
            char[] sonuc = new char[string_1.Length + string_2.Length];
            baslangic = 0;
            for (int i = 0; i < (string_1.Length + string_2.Length); i++)
            {
                if (i < string_1.Length)
                {
                    sonuc[i] = string_1[i];//ilk kelime
                }
                else
                {
                    sonuc[i] = string_2[baslangic];//devamına ikinci kelime
                    baslangic++;
                }
            }
            sonuc_dondur = new string(sonuc);
            return sonuc_dondur;
        }
        public string ArayaGir(int indis, string string_1, string string_2)
        {
            char[] sonuc = new char[string_1.Length + string_2.Length];
            int gir_sayac = 0;
            int metin_devam = 0;
            for (int i = 0; i < (string_1.Length + string_2.Length); i++)//diziye değerlerin atanması işlemi
            {
                if (i < indis)
                {
                    sonuc[i] = string_2[i];//indexe kadar text elemanları chara atanır
                    metin_devam++;
                }
                else if (i < (indis + string_1.Length))
                {
                    sonuc[i] = string_1[gir_sayac];//araya girilen kelime
                    gir_sayac++;
                }
                else
                {
                    sonuc[i] = string_2[metin_devam];//metin devamı
                    metin_devam++;
                }
            }
            sonuc_dondur = new string(sonuc);//dizi stringe dönüştürülür
            return sonuc_dondur;//değer geri döndürülür
        }
        public char[] CharDiziyeDonustur(string string_1)
        {
            char[] sonuc = new char[string_1.Length];
            for (int i = 0; i < string_1.Length; i++)//degerler tek tek char dizisine atanır
            {
                sonuc[i] = string_1[i];
            }
            return sonuc;
        }
        public int Degerİndis(string string_1, string string_2)
        {
            int kelime_kontrol = 0, sayac = 0;
            int sonuc = -1;
            if (string_1 != "")
            {
                for (sayac = 0; sayac < string_2.Length; sayac++)
                {
                    if (string_2[sayac] == string_1[kelime_kontrol])
                    {
                        kelime_kontrol++;
                    }
                    else
                        kelime_kontrol = 0;
                    if (kelime_kontrol == string_1.Length)
                    {
                        sonuc = sayac - (string_1.Length - 1);
                        break;//ilk bulunun indisde döngü sonlanır
                    }
                }
                return sonuc;//deger döndürülür
            }
            else
                return 0;
        }
        public string DegerAl(int indis, string string_1)
        {
            if (indis <= string_1.Length && indis >= 0)//text degeri boş olmadığında çalışır
            {
                char[] bolunmus = new char[string_1.Length - indis];
                ilk_sayac = 0;
                for (; indis < string_1.Length; indis++)
                {
                    bolunmus[ilk_sayac] = string_1[indis];//değer atama
                    ilk_sayac++;
                }
                sonuc_dondur = new string(bolunmus);
                return sonuc_dondur;
            }
            else
                return "";//metin boşluk ise çalişir
        }
        public string[] DiziyeAyir(string karakter, string string_1)
        {
            string gecici = string_1; int sayac_char = 0;
            while (Degerİndis(karakter, gecici) != -1)
            {
                gecici = DegerAl(Degerİndis(karakter, gecici) + karakter.Length, gecici);
                sayac_char++;
            }
            string[] sonuc = new string[(sayac_char + 1)]; gecici = string_1;
            for (int i = 0; i < sayac_char + 1; i++)
            {
                int index = Degerİndis(karakter, gecici);
                if (index != -1)
                {
                    char[] eleman = new char[index];
                    for (int j = 0; j < index; j++)
                    {
                        eleman[j] = gecici[j];
                    }
                    sonuc[i] = new string(eleman);//elemanlar diziye atanır
                    gecici = DegerAl(Degerİndis(karakter, gecici) + karakter.Length, gecici);//metin karakterin bulunduğu index de dahil olmak üzere kesilir
                }
                else
                {
                    sonuc[i] = gecici;//son parça için ve aranan karakterin olmaması durumu için çalışır
                }
            }
            return sonuc;//dizi döndürülür
        }
        public string[] SiralaAZ(string[] dizi_string)
        {
            var listeAZ = new List<string>();
            int index = 0;
            char[] harfler = CharDiziyeDonustur("ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ");//harfler oluşturulur
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < dizi_string.Length; j++)
                {
                    if ((dizi_string[j].ToUpper())[0] == harfler[i])
                    {
                        listeAZ.Add(dizi_string[j]);//sırayla listeye atama işlemi
                    }
                }
            }
            foreach (string str in listeAZ)//Degerler diziye atanır
            {
                dizi_string[index] = str;
                index++;
            }
            return dizi_string;//dizi döndürülür
        }
        public string[] SiralaZA(string[] dizi_string)
        {
            var listeZA = new List<string>();
            int index = 0;
            char[] harfler = CharDiziyeDonustur("ZYXWVÜUTŞSRQPÖONMLKJİIHĞGFEDÇCBA");//harfler oluşturulur
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < dizi_string.Length; j++)
                {
                    if ((dizi_string[j].ToUpper())[0] == harfler[i])
                    {
                        listeZA.Add(dizi_string[j]);//sırayla listeye atama işlemi
                    }
                }
            }
            foreach (string str in listeZA)//Degerler diziye atanır
            {
                dizi_string[index] = str;
                index++;
            }
            return dizi_string;//dizi döndürülür
        }
        public string TersCevir(string string_1)
        {
            char[] ters_dizi = new char[string_1.Length];
            for (int i = 0; i < string_1.Length; i++)
            {
                ters_dizi[i] = string_1[string_1.Length - 1 - i];//degerler tersten atanır
            }
            string_1 = new string(ters_dizi);
            return string_1;
        }
    }
}
