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
namespace soru2_
{
    class MatrisIslem
    {
        public static double[,] Toplama(double[,] matris1, double[,] matris2)//toplama işlemi
        {
            double[,] sonuc = new double[matris1.GetLength(0), matris1.GetLength(0)];//gerekli boyutta sonuc matrisi oluşturulur
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(0); j++)
                {
                    sonuc[i, j] = matris1[i, j] + matris2[i, j];//indexkleri eşit olanlar toplanır
                }
            }
            return sonuc;
        }


        public static double[,] Carpma(double[,] matris1, double[,] matris2)
        {
            
            int boyut = matris1.GetLength(0);
            double[,] sonuc = new double[boyut, boyut];//gerekli boyutta sonuc matrisi oluşturulur
            if (boyut == 3)
            {
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 3; j++)//boyutu 3 olan matris için çarpma sonucu bulma
                    {
                        sonuc[i, j] = matris1[i, 0] * matris2[0, j] + matris1[i, 1] * matris2[1, j] + matris1[i, 2] * matris2[2, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < 2; j++)//boyutu 2 olan matris için çarpma sonucu bulma
                    {
                        sonuc[i, j] = matris1[i, 0] * matris2[0, j] + matris1[i, 1] * matris2[1, j];//2x2 matris için çarpma işlemi yapılır
                    }
                }
            }
            return sonuc;
        }


        


        public static Tuple<double, double[,]> TersAl(double[,] matris)
        {
            double Determinant = 0;
            double[,] sonuc = new double[matris.GetLength(0), matris.GetLength(0)];//gerekli boyutta sonuc dizisi oluşturulur

            if(matris.GetLength(0)==3)//matris boyutu 3 olması durumu
            {
                for (int i = 0; i < 3; i++)
                {
                    /*determinant denklemi*/
                    Determinant = Determinant + (matris[0, i] * (matris[1, (i + 1) % 3] * matris[2, (i + 2) % 3] - matris[1, (i + 2) % 3] * matris[2, (i + 1) % 3]));
                }
                if (Determinant == 0)//determinantın sıfır olması durumu
                {
                    return new Tuple<double, double[,]>(Determinant, sonuc);
                }
                else
                {
                    sonuc[0, 0] = matris[1, 1] * matris[2, 2] - matris[1, 2] * matris[2, 1];
                    sonuc[0, 1] = -(matris[0, 1] * matris[2, 2] - matris[0, 2] * matris[2, 1]);
                    sonuc[0, 2] = matris[0, 1] * matris[1, 2] - matris[0, 2] * matris[1, 1];
                    sonuc[1, 0] = -(matris[1, 0] * matris[2, 2] - matris[1, 2] * matris[2, 0]);
                    sonuc[1, 1] = matris[0, 0] * matris[2, 2] - matris[0, 2] * matris[2, 0];
                    sonuc[1, 2] = -(matris[0, 0] * matris[1, 2] - matris[0, 2] * matris[1, 0]);
                    sonuc[2, 0] = matris[1, 0] * matris[2, 1] - matris[1, 1] * matris[2, 0];
                    sonuc[2, 1] = -(matris[0, 0] * matris[2, 1] - matris[0, 1] * matris[2, 0]);
                    sonuc[2, 2] = matris[0, 0] * matris[1, 1] - matris[0, 1] * matris[1, 0];//ek matris hesaplamaları
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sonuc[i, j] = sonuc[i, j] / Determinant;//son aşamada ek matris determinant degerine bölünür
                        }
                    }
                }
            }
            else//matris boyutu 2 olması durumu
            {
                double gecici = 0;
                //determinant hesaplanır
                Determinant = matris[0, 0] * matris[1, 1] - matris[0, 1] * matris[1, 0];
                if (Determinant == 0)//determinant degerinin sıfır olması durumu
                {
                    return new Tuple<double, double[,]>(Determinant, sonuc);
                }
                else
                {
                    for (int i = 0; i < matris.GetLength(0); i++)
                    {
                        for (int j = 0; j < matris.GetLength(0); j++)
                        {
                            if (i != j)
                            {
                                matris[i, j] = (-1) * matris[i, j];
                            }
                            else
                            {
                                if (i + 1 == matris.GetLength(0))
                                {
                                    matris[i, j] = gecici;
                                }
                                else
                                {
                                    gecici = matris[i, j];
                                    matris[i, j] = matris[i + 1, j + 1];
                                }

                            }

                        }
                    }
                    for (int i = 0; i < matris.GetLength(0); i++)
                    {
                        for (int j = 0; j < matris.GetLength(0); j++)
                        {
                            sonuc[i, j] = matris[i, j] / Determinant;//bulunan ek matris det bölünür ve ters matris degeri bulunur
                        }
                    }
                }
            }
            return new Tuple<double, double[,]>(Determinant, sonuc);
        }

        public static string Okuma()
        {
            string okunan = File.ReadAllText("dosya.txt");//dosyadan verilerin tamamı okunur
            return okunan;//ve geri döndürülür
        }


        public static void Yazdir(string metin)
        {
            string yaz = MatrisIslem.Okuma() + metin + "\n.............................\n\n";//dosyadan okunan ve dosyaya yazılacak stringler bir stringde birleştirilir
            File.WriteAllText("gecici.tmp", yaz);//gecici bir dosyaya yazdırılır
            File.Delete("dosya.txt");//eski dosya silinir
            File.Move("gecici.tmp", "dosya.txt");//gecici dosya eski dosyanın yerine gecer
        }

        public static double IzBul(double[,] matris)
        {
            double sonuc = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    if (i == j)//satır ve sütun indisleri eşit olan degerler toplanır
                    {
                        sonuc = sonuc + matris[i, j];
                    }
                }
            }
            return sonuc;
        }


        public static double[,] Transpoze(double[,] matris)
        {
            double[,] sonuc = new double[matris.GetLength(0), matris.GetLength(0)];
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    sonuc[j, i] = matris[i, j];//matrisin satir ve sütun indisleri yer değiştirilirs
                }
            }
            return sonuc;
        }
    }
}
