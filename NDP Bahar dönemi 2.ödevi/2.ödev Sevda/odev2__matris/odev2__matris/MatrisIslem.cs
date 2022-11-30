/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:2
**				ÖĞRENCİ ADI............:
**				ÖĞRENCİ NUMARASI.......:
**              DERSİN ALINDIĞI GRUP...:
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace odev2__matris
{
    public static class MatrisIslem
    {
        public static string Toplama(double[,] ilk_matris, double[,] ikinci_matris)
        {
            double[,] cevap_matris = ilk_matris;
            for (int i = 0; i < cevap_matris.GetLength(0); i++)
            {
                for (int j = 0; j < cevap_matris.GetLength(1); j++)
                {
                    cevap_matris[i, j] = ilk_matris[i, j] + ikinci_matris[i, j];//indexleri eşit olan elemanlar toplanır
                }
            }
            string dondurulecek = "";
            for (int i = 0; i < cevap_matris.GetLength(0); i++)
            {
                for (int j = 0; j < cevap_matris.GetLength(1); j++)
                {
                    dondurulecek = dondurulecek + cevap_matris[i, j] + "   ";//sonuc string olarak geri döndürülür
                }
                dondurulecek = dondurulecek + "\n";
            }
            return dondurulecek;
        }

        public static string Carpma(double[,] ilk_matris, double[,] ikinci_matris)
        {
            int boyut = ilk_matris.GetLength(0);
            string dondurulecek = "";
            if (boyut == 3)//3x3 matris için
            {
                double[,] cevap_matris = new double[3, 3];
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cevap_matris[i, j] = ilk_matris[i, 0] * ikinci_matris[0, j] + ilk_matris[i, 1] * ikinci_matris[1, j] + ilk_matris[i, 2] * ikinci_matris[2, j];
                    }
                }
                dondurulecek = "";
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        dondurulecek = dondurulecek + cevap_matris[i, j] + "   ";//sonuc string olarak geri döndürülür
                    }
                    dondurulecek = dondurulecek + "\n";
                }
            }
            else//2x2 matris için
            {
                double[,] sonuc = new double[3, 3];
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        sonuc[i, j] = ilk_matris[i, 0] * ikinci_matris[0, j] + ilk_matris[i, 1] * ikinci_matris[1, j];
                    }
                }
                dondurulecek="";
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        dondurulecek = dondurulecek + sonuc[i, j] + "   ";//sonuc string olarak geri döndürülür
                    }
                    dondurulecek = dondurulecek + "\n";
                }
            }
            return dondurulecek;
        }

        public static string TersAl(double[,] ilk_matris)
        {
            string dondurulecek = "";
            double Determinant = 0;
            int boyut = ilk_matris.GetLength(0);
            if (boyut == 3)//3x3 matris için
            {
                double[,] cevap_matris = new double[3, 3];

                for (int i = 0; i < 3; i++)
                    Determinant = Determinant + (ilk_matris[0, i] * (ilk_matris[1, (i + 1) % 3] * ilk_matris[2, (i + 2) % 3] - ilk_matris[1, (i + 2) % 3] * ilk_matris[2, (i + 1) % 3]));//det hesaplanır
                if (Determinant == 0)//det kontrol edilir
                {
                    dondurulecek = "bu Matrisin Tersi Hesaplanamaz";
                    return dondurulecek;
                }
                else
                {

                    //adjoint matris
                    cevap_matris[0, 0] = ilk_matris[1, 1] * ilk_matris[2, 2] - ilk_matris[1, 2] * ilk_matris[2, 1]; 
                    cevap_matris[0, 1] = -(ilk_matris[0, 1] * ilk_matris[2, 2] - ilk_matris[0, 2] * ilk_matris[2, 1]); 
                    cevap_matris[0, 2] = ilk_matris[0, 1] * ilk_matris[1, 2] - ilk_matris[0, 2] * ilk_matris[1, 1];

                    cevap_matris[1, 0] = -(ilk_matris[1, 0] * ilk_matris[2, 2] - ilk_matris[1, 2] * ilk_matris[2, 0]); 
                    cevap_matris[1, 1] = ilk_matris[0, 0] * ilk_matris[2, 2] - ilk_matris[0, 2] * ilk_matris[2, 0]; 
                    cevap_matris[1, 2] = -(ilk_matris[0, 0] * ilk_matris[1, 2] - ilk_matris[0, 2] * ilk_matris[1, 0]);

                    cevap_matris[2, 0] = ilk_matris[1, 0] * ilk_matris[2, 1] - ilk_matris[1, 1] * ilk_matris[2, 0]; 
                    cevap_matris[2, 1] = -(ilk_matris[0, 0] * ilk_matris[2, 1] - ilk_matris[0, 1] * ilk_matris[2, 0]); 
                    cevap_matris[2, 2] = ilk_matris[0, 0] * ilk_matris[1, 1] - ilk_matris[0, 1] * ilk_matris[1, 0];

                    for (int i = 0; i < boyut; i++)
                    {
                        for (int j = 0; j < boyut; j++)
                        {
                            cevap_matris[i, j] = cevap_matris[i, j] / Determinant;//ek matris det degerine bölünür ve ters matris elde edilir
                        }
                    }
                    for (int i = 0; i < boyut; i++)
                    {
                        for (int j = 0; j < boyut; j++)
                        {
                            dondurulecek = dondurulecek + cevap_matris[i, j] + "   ";
                        }
                        dondurulecek = dondurulecek + "\n";
                    }
                    return dondurulecek;
                }
            }
            else
            {
                double[,] sonuc = new double[3, 3];
                double gecici = 0;
                Determinant = ilk_matris[0, 0] * ilk_matris[1, 1] - ilk_matris[0, 1] * ilk_matris[1, 0];//det hesaplanır
                if (Determinant == 0)
                {
                    dondurulecek = "Det = 0 olduğu için Matrisin tersi yok.";//sıfır olması durumu kontrol edilir
                    return dondurulecek;
                }
                else
                {
                    for (int i = 0; i < boyut; i++)
                    {
                        for (int j = 0; j < boyut; j++)
                        {
                            if (i != j)
                            {
                                ilk_matris[i, j] = (-1) * ilk_matris[i, j];//ek matris bulma sırasında önüne eksi gelicek olan degerlere işlem yapılır
                            }
                            else
                            {
                                if (i + 1 == boyut)
                                {
                                    ilk_matris[i, j] = gecici;//ek matrisi bulunur
                                }
                                else
                                {
                                    gecici = ilk_matris[i, j];//ek matris bulma işlemi
                                    ilk_matris[i, j] = ilk_matris[i + 1, j + 1];
                                }

                            }

                        }
                    }
                    for (int i = 0; i < boyut; i++)
                    {
                        for (int j = 0; j < boyut; j++)
                        {
                            ilk_matris[i, j] = ilk_matris[i, j] / Determinant;//bulunan ek matris det bölünür ve ters matris degeri bulunur
                            dondurulecek = dondurulecek + ilk_matris[i, j] + "   ";
                        }
                        dondurulecek = dondurulecek + "\n";
                    }
                }
                return dondurulecek;
            }
        }

        public static string IzBul(double[,] ilk_matris)
        {
            string dondurulecek = "";
            double cevap = 0;
            for (int i = 0; i < ilk_matris.GetLength(0); i++)
            {
                for (int j = 0; j < ilk_matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        cevap = cevap + ilk_matris[i, j];//köşegendeki elemanlar toplanır
                    }
                }
            }
            dondurulecek = Convert.ToString(cevap);
            return dondurulecek;
        }

        public static string Transpoze(double[,] ilk_matris)
        {
            string dondurulecek = "";
            double[,] cevap_matris = ilk_matris;
            for (int i = 0; i < ilk_matris.GetLength(0); i++)
            {
                for (int j = 0; j < ilk_matris.GetLength(1); j++)
                {
                    dondurulecek = dondurulecek + cevap_matris[j, i] + "   ";//indexlerin yerleri değiştirilerek diziye atanır
                }
                dondurulecek = dondurulecek + "\n";
            }
            return dondurulecek;
        }
        public static string Okuma()
        {
            string dosya_icerik = File.ReadAllText("kayit.txt");//dosyadan okunan veriler stringe atanır
            return dosya_icerik;//string değeri döndürülür
        }
        public static void Yazdir(string metin)//dosyaya veriler yazdırılır
        {
            string yazilacak = MatrisIslem.Okuma() + metin + "\n*************************************************\n\n";
            File.WriteAllText("gecici.txt", yazilacak);//string degeri gecici dosyaya kayıt edilir
            File.Delete("kayit.txt"); // eski dosya silinir
            File.Move("gecici.txt", "kayit.txt"); // gecici dosyanın ismi değiştirilir
        }
    }
}
