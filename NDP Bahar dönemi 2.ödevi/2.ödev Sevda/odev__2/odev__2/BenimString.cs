/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:2
**				ÖĞRENCİ ADI............:
**				ÖĞRENCİ NUMARASI.......:
**              DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace odev__2
{
    class BenimString
    {
        private int sayac = 0;
        private int baslangic = 0;
        private int ilk_sayac = 0;

        private string final_form;

        public int ElemanSayısı(string text)
        {
            sayac = 0;
            foreach (char karakter in text)
            {
                sayac++;//karakterler sayılır
            }
            return sayac;
        }

        public string Birlestir(string text1, string text2)
        {
            char[] birlesmis = new char[text1.Length + text2.Length];//gerekli boyuutta dizi oluşturulur
            baslangic = 0;
            for (int i = 0; i < (text1.Length + text2.Length); i++)
            {
                if (i < text1.Length)
                {
                    birlesmis[i] = text1[i];//ilk kelime
                }
                else
                {
                    birlesmis[i] = text2[baslangic];//devamına ikinci kelime
                    baslangic++;
                }
            }
            final_form = new string(birlesmis);//tip dönüşümü
            return final_form;
        }

        public string ArayaGir(int index, string gir, string text)
        {
            char[] degistirilmis = new char[gir.Length + text.Length];
            int gir_sayac = 0;
            int metin_devam = 0;
            for (int i = 0; i < (gir.Length + text.Length); i++)//diziye değerlerin atanması işlemi
            {
                if (i < index)
                {
                    degistirilmis[i] = text[i];//indexe kadar text elemanları chara atanır
                    metin_devam++;//yazdırmaya devam etmek için kullanılacak değişken
                }
                else if (i < (index + gir.Length))
                {
                    degistirilmis[i] = gir[gir_sayac];
                    gir_sayac++;//araya girilecek kelimenin indexini tutan sayac
                }
                else
                {
                    degistirilmis[i] = text[metin_devam];//tip dönüşümü
                    metin_devam++;
                }
            }
            final_form = new string(degistirilmis);//dizi stringe dönüştürülür
            return final_form;//değer geri döndürülür
        }

        public char[] CharDiziyeDonustur(string text)
        {
            char[] donustur = new char[text.Length];
            for (int i = 0; i < text.Length; i++)//degerler tek tek char dizisine atanır
            {
                donustur[i] = text[i];
            }
            return donustur;
        }

        public int Degerİndis(string str, string text)
        {
            int str_ = 0;
            int text_ = 0;
            int indis = -1;
            if (str != "")//boş olması durumu kontrol edilir
            {
                for (text_ = 0; text_ < text.Length; text_++)
                {
                    if (text[text_] == str[str_])
                    {
                        str_++;
                    }
                    else
                        str_ = 0;
                    if (str_ == str.Length)
                    {
                        indis = text_ - (str.Length - 1);
                        break;//ilk bulunun indisde döngü sonlanır
                    }
                }
                return indis;//deger döndürülür
            }
            else
                return 0;
        }

        public string DegerAl(int index, string text)
        {
            if (index <= text.Length && index >= 0)//text degeri boş olmadığında çalışır
            {
                char[] bolunmus = new char[text.Length - index];
                ilk_sayac = 0;
                for (; index < text.Length; index++)
                {
                    bolunmus[ilk_sayac] = text[index];//değer atama
                    ilk_sayac++;
                }
                final_form = new string(bolunmus);
                return final_form;
            }
            else
                return "";//metin boşluk ise çalişir
        }

        public string[] DiziyeAyir(string chr, string text)
        {
            string tmp = text;
            int karakter_say = 0;
            while (Degerİndis(chr, tmp) != -1)//karakterin kaç kere metinde geçtiğine bakılır
            {
                tmp = DegerAl(Degerİndis(chr, tmp) + chr.Length, tmp);
                karakter_say++;
            }
            string[] ayrilmis = new string[(karakter_say + 1)];
            tmp = text;
            for (int i = 0; i < karakter_say + 1; i++)
            {
                int index = Degerİndis(chr, tmp);
                if (index != -1)
                {
                    char[] eleman = new char[index];
                    for (int j = 0; j < index; j++)
                    {
                        eleman[j] = tmp[j];
                    }
                    ayrilmis[i] = new string(eleman);//elemanlar diziye atanır
                    tmp = DegerAl(Degerİndis(chr, tmp) + chr.Length, tmp);//metin karakterin bulunduğu index de dahil olmak üzere kesilir
                }
                else
                {
                    ayrilmis[i] = tmp;//son parça için ve aranan karakterin olmaması durumu için çalışır
                }
            }
            return ayrilmis;//dizi döndürülür
        }

        public string[] SiralaAZ(string[] str_dizi)
        {
            var listeAZ = new List<string>();

            int index = 0;
            string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ"; 
            char[] harfler = CharDiziyeDonustur(alfabe);//harfler oluşturulur
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < str_dizi.Length; j++)
                {
                    if ((str_dizi[j].ToUpper())[0] == harfler[i])
                    {
                        listeAZ.Add(str_dizi[j]);//sırayla listeye atama işlemi
                    }
                }
            }
            foreach (string str in listeAZ)//Degerler diziye atanır
            {
                str_dizi[index] = str;
                index++;
            }
            return str_dizi;//dizi döndürülür
        }

        public string[] SiralaZA(string[] str_dizi)
        {
            string[] A_Z = SiralaAZ(str_dizi);
            string[] Z_A = new string[A_Z.Length];
            int x = 1;
            for (int i = 0; i < A_Z.Length; i++)
            {
                Z_A[A_Z.Length - x] = A_Z[i];
                x++;
            }
            return Z_A;//tersten olan dizi döndürülür
        }

        public string TersCevir(string text)
        {
            char[] dizi_toplam = new char[text.Length];
            int ters = text.Length - 1;
            for (int i = 0; i < text.Length; i++)
            {
                dizi_toplam[i] = text[ters];//degerler tersten atanır
                ters--;
            }
            text = new string(dizi_toplam);
            return text;
        }
    }
}
