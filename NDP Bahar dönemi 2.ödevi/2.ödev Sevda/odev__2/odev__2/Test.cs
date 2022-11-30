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
using System.Text;
namespace odev__2
{
    class Test
    {
        BenimString nesne = new BenimString();
        private int islem_sirasi = 1;
        public void test()
        {
            Console.WriteLine(islem_sirasi+")**************************************************");
            islem_sirasi++;
            string test_str = "test_string_metni";
            
            Console.WriteLine("Test string :"+test_str);
            Console.WriteLine("ElemanSayı :" + nesne.ElemanSayısı(test_str)+"\n");


            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            string tset_1 = "String ifadeleri";
            string test_2 = " birleştiren fonksiyon";
            Console.WriteLine("metin :" + tset_1 + "\nmetin :" + test_2);
            Console.WriteLine("\nBirlestir :" + nesne.Birlestir(tset_1, test_2)+"\n");

            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            test_str = "125";
            string gir = "34";
            Console.WriteLine("metin :" + test_str + "\ngir :" + gir);
            Console.WriteLine("\nArayaGir :"+nesne.ArayaGir(2, gir, test_str)+"\n");

            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            test_str = "Test";
            Console.WriteLine("ifade :" + test_str);
            char[] test_dizi = nesne.CharDiziyeDonustur(test_str);
            for (int i = 0; i < test_dizi.Length; i++)
            {
                Console.WriteLine(test_dizi[i]);
            }
            Console.Write("\n");

            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            test_str = "Burada kar yağıyor";
            string bul = "kar";
            Console.WriteLine("ifade :" + test_str + "\naranan :" + bul); 
            Console.WriteLine("\nDegerİndis :" + nesne.Degerİndis(bul, test_str) + "\n");

            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            string bolunmus = nesne.DegerAl(3, test_str);
            Console.WriteLine("ifade :" + test_str + "\nindex :" + 3 + "\n");
            Console.WriteLine("DegerAl :" + bolunmus+"\n");

            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            string chr = "_";
            test_str = "Ayrılacak_örnek_metin_ve_örnek_karakter";
            string[] test_dizi2 = nesne.DiziyeAyir(chr, test_str);
            Console.WriteLine("ifade :" + test_str + "\nkarakter :" + chr + "\n");
            Console.WriteLine("DiziyeAyir :\n");
            for (int i = 0; i < test_dizi2.Length; i++)
            {
                Console.WriteLine(test_dizi2[i]);
            }
            Console.WriteLine();
            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            string[] deneme = { "Burak", "Ziya", "Cem", "Mehmet", "Ahmet", "Furkan", "Bunyamin", "Ömer" };
            Console.WriteLine("Dizi içeriği:\n");
            for (int i = 0; i < deneme.Length; i++)
            {
                Console.WriteLine(deneme[i]);
            }
            Console.WriteLine();
            nesne.SiralaAZ(deneme);
            Console.WriteLine("SiralaAZ(dizi)\n");
            for (int i = 0; i < deneme.Length; i++)
            {
                Console.WriteLine(deneme[i]);
            }
            Console.WriteLine();
            Console.WriteLine(islem_sirasi + ")**************************************************");
            islem_sirasi++;
            string[] deneme2 = { "Burak", "Ziya", "Cem", "Mehmet", "Ahmet", "Furkan", "Bunyamin", "Ömer" };
            Console.WriteLine("Dizi içeriği:\n");
            for (int i = 0; i < deneme2.Length; i++)
            {
                Console.WriteLine(deneme2[i]);
            }
            Console.WriteLine();
            string[] ters = nesne.SiralaZA(deneme2);
            Console.WriteLine("SiralaZA(dizi)\n");
            for (int i = 0; i < ters.Length; i++)
            {
                Console.WriteLine(ters[i]);
            }
            Console.WriteLine();

            Console.WriteLine(islem_sirasi + "****************************************************");
            islem_sirasi++;
            test_str = "nitem kecelirveç sreT";
            string ters_ = nesne.TersCevir(test_str);
            Console.Write("ifade: " + test_str + "\n");
            Console.WriteLine("TersCevir: " + ters_ + "\n");
            Console.WriteLine("******************************************************");
            Console.ReadLine();
        }
    }
}