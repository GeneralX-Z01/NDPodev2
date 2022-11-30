/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Fuad Garibli
**				ÖĞRENCİ NUMARASI.......: g201210558
**              DERSİN ALINDIĞI GRUP...: 2.öğretim C grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace soru1_
{
    class StringTest
    {
        BenimString nesne = new BenimString();
        public void calistir()
        {
            int islem_sirasi = 1;
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string test_str = "NDP ödevini yapıyorum";
            Console.WriteLine("Test string :" + test_str);
            Console.Write("ElemanSayı :" + nesne.ElemanSayısı(test_str) + "\n");
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string tset_1 = "NDP ödevi";
            string test_2 = "ni yapıyorum";
            Console.WriteLine("metin :" + tset_1 + "\nmetin :" + test_2);
            Console.Write("\nBirlestir :" + nesne.Birlestir(tset_1, test_2) + "\n");
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            test_str = "NDP  yapıyorum";
            string gir = "ödevini";
            Console.WriteLine("metin :" + test_str + "\ngir :" + gir);
            Console.WriteLine("\nArayaGir :" + nesne.ArayaGir(4, gir, test_str));
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            test_str = "Test";
            Console.WriteLine("ifade :" + test_str);
            char[] test_dizi = nesne.CharDiziyeDonustur(test_str);
            for (int i = 0; i < test_dizi.Length; i++)
            {
                Console.WriteLine(test_dizi[i]);
            }
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            test_str = "NDP ödevini yapıyorum";
            string bul = "ödevini";
            Console.WriteLine("ifade :" + test_str + "\naranan :" + bul);
            Console.WriteLine("Degerİndis :" + nesne.Degerİndis(bul, test_str));
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string sonuc = nesne.DegerAl(7, test_str);
            Console.WriteLine("ifade :" + test_str + "\nindex :" + 7 + "\n");
            Console.WriteLine("DegerAl :" + sonuc);
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string chr = "_";
            test_str = "NDP_ödevini_yapıyorum";
            string[] test_dizi2 = nesne.DiziyeAyir(chr, test_str);
            Console.WriteLine("ifade :" + test_str + "\nkarakter :" + chr + "\n");
            Console.Write("DiziyeAyir :\n");
            for (int i = 0; i < test_dizi2.Length; i++)
            {
                Console.WriteLine(test_dizi2[i]);
            }
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string[] test_array = { "NDP", "ödevini", "yapıyorum", "aAa" };
            Console.Write("Dizi içeriği:\n");
            for (int i = 0; i < test_array.Length; i++)
            {
                Console.WriteLine(test_array[i]);
            }
            nesne.SiralaAZ(test_array);
            Console.Write("\nSiralaAZ:\n");
            for (int i = 0; i < test_array.Length; i++)
            {
                Console.WriteLine(test_array[i]);
            }
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi++;
            string[] test_array_1 = { "NDP", "ödevini", "yapıyorum", "ZzZ" };
            Console.Write("Dizi içeriği:\n");
            for (int i = 0; i < test_array_1.Length; i++)
            {
                Console.WriteLine(test_array_1[i]);
            }
            nesne.SiralaZA(test_array_1);
            Console.Write("\nSiralaZA:\n");
            for (int i = 0; i < test_array_1.Length; i++)
            {
                Console.WriteLine(test_array_1[i]);
            }
            Console.Write("............[" + islem_sirasi + "]............\n"); islem_sirasi = 0;
            test_str = "muroyıpay inivedö PDN";
            string ters_ = nesne.TersCevir(test_str);
            Console.Write("ifade: " + test_str + "\n");
            Console.WriteLine("TersCevir: " + ters_);
            Console.WriteLine("............................");
        }
    }
}
