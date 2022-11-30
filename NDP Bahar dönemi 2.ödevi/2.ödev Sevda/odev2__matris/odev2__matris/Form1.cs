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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace odev2__matris
{
    public partial class Form1 : Form
    {
        public int boyut = 0,matris_sayi=0,girdi_say=0,islem_sira=0,islem_no=0;
        double[,] matris1;
        double[,] matris2;

        private string StringeDonustur(double[,] dizi)
        {
            string yaz = "";
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    yaz = yaz + dizi[i, j] + "   ";//her eleman sonuna boşluk eklenir
                }
                yaz = yaz + "\n";//her satır sonunda yeni satır eklenir
            }
            return yaz;
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        public Form1()//form****
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 3;islem_sira++;
            boyut_panel.Enabled = false;
            
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boyut = 2;islem_sira++;
            matris_panel.Visible = false;
            boyut_panel.Enabled = false;
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void degerGir_Click(object sender, EventArgs e)
        {
            if(matris_sayi==1)//eğer sadece 1 matris gereken işlem yapılıyorsa matris degeri bir kez alınır
            {
                degerGir.Enabled = false;
                string[,] matris_1 = new string[boyut, boyut];
                matris_1[0, 0] = m1x1.Text;matris_1[0, 1] = m1x2.Text;//2x2 lik matris için kullanılan kısımlar
                if (boyut == 3){
                    matris_1[0, 2] = m1x3.Text;//3x3 lük matris olması durumu
                }
                matris_1[1, 0] = m2x1.Text;matris_1[1, 1] = m2x2.Text;//2x2 lik matris için kullanılan kısımlar
                if (boyut == 3){//3x3 lük matris olması durumu
                    matris_1[1, 2] = m2x3.Text;matris_1[2, 0] = m3x1.Text;matris_1[2, 1] = m3x2.Text;matris_1[2, 2] = m3x3.Text;
                }
                double[,] gecici = new double[matris_1.GetLength(0), matris_1.GetLength(1)];
                for (int i = 0; i < matris_1.GetLength(0); i++){
                    for (int j = 0; j < matris_1.GetLength(1); j++){
                        if (matris_1[i, j] == ""){
                            matris_1[i, j] = "0";
                        }
                        else
                            gecici[i, j] = Convert.ToDouble(matris_1[i, j]);
                    }
                }
                matris1 = gecici;
                richTextBox1.AppendText("\nilk Matris Degerleri\n\n" + StringeDonustur(matris1));

                //hesaplama işleminde çağrilacak fonksiyonun hangisi olacaği kontrol edilir
                if (islem_no == 1)
                {
                    richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Toplama(matris1, matris2)); 
                }
                else if (islem_no == 2)
                {
                    richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Carpma(matris1, matris2)); 
                }
                else if (islem_no == 3)
                {
                    richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.TersAl(matris1)); 
                }
                else if (islem_no == 4)
                {
                    richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.IzBul(matris1)); 
                }
                else if (islem_no == 5)
                {
                    richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Transpoze(matris1)); 
                }
                MatrisIslem.Yazdir(richTextBox1.Text);
            }
            else
            {
                girdi_say++;
                if(girdi_say==1)//ilk matris değeri girilir
                {
                    string[,] matris_1 = new string[boyut, boyut];
                    matris_1[0, 0] = m1x1.Text;matris_1[0, 1] = m1x2.Text;
                    if (boyut == 3){
                        matris_1[0, 2] = m1x3.Text;
                    }
                    matris_1[1, 0] = m2x1.Text;matris_1[1, 1] = m2x2.Text;
                    if (boyut == 3){
                        matris_1[1, 2] = m2x3.Text;matris_1[2, 0] = m3x1.Text;matris_1[2, 1] = m3x2.Text;matris_1[2, 2] = m3x3.Text;
                    }
                    double[,] gecici = new double[matris_1.GetLength(0), matris_1.GetLength(1)];
                    for (int i = 0; i < matris_1.GetLength(0); i++){
                        for (int j = 0; j < matris_1.GetLength(1); j++){
                            if (matris_1[i, j] == ""){
                                matris_1[i, j] = "0";
                            }
                            else
                                gecici[i, j] = Convert.ToDouble(matris_1[i, j]);
                        }
                    }
                    matris1 = gecici;
                    richTextBox1.AppendText("\nilk Matris Degerleri\n\n" + StringeDonustur(matris1));
                    matrisBilgi.Text = "Ikinci Matrisi";

                    m1x1.Text = "";   m1x2.Text = "";   m1x3.Text = "";//textbox degerleri sıfırlanır
                    m2x1.Text = "";   m2x2.Text = "";   m2x3.Text = "";
                    m3x1.Text = "";   m3x2.Text = "";   m3x3.Text = "";
                }
                else if(girdi_say==2)//ikinci matris degerleri girildikten sonrahesaplama işlemi yapılır
                {
                    degerGir.Enabled = false;
                    string[,] matris_2 = new string[boyut, boyut];
                    matris_2[0, 0] = m1x1.Text;matris_2[0, 1] = m1x2.Text;
                    if (boyut == 3){
                        matris_2[0, 2] = m1x3.Text;
                    }
                    matris_2[1, 0] = m2x1.Text;matris_2[1, 1] = m2x2.Text;
                    if (boyut == 3){
                        matris_2[1, 2] = m2x3.Text;matris_2[2, 0] = m3x1.Text;matris_2[2, 1] = m3x2.Text;matris_2[2, 2] = m3x3.Text;
                    }
                    double[,] gecici = new double[matris_2.GetLength(0), matris_2.GetLength(1)];
                    for (int i = 0; i < matris_2.GetLength(0); i++) 
                    {
                        for (int j = 0; j < matris_2.GetLength(1); j++){
                            if (matris_2[i, j] == ""){
                                matris_2[i, j] = "0";
                            }
                            else
                                gecici[i, j] = Convert.ToDouble(matris_2[i, j]);
                        }
                    }
                    matris2 = gecici;
                    richTextBox1.AppendText("\nikinci Matris Degerleri\n\n" + StringeDonustur(matris2));

                    //hesaplama işleminde çağrilacak fonksiyonun hangisi olacaği kontrol edilir
                    if (islem_no == 1)
                    {
                        richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Toplama(matris1, matris2));
                    }
                    else if (islem_no == 2)
                    {
                        richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Carpma(matris1, matris2)); 
                    }
                    else if (islem_no == 3) 
                    {
                        richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.TersAl(matris1));
                    }
                    else if (islem_no == 4) 
                    {
                        richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.IzBul(matris1)); 
                    }
                    else if (islem_no == 5) 
                    {
                        richTextBox1.AppendText("\nSonuc\n" + MatrisIslem.Transpoze(matris1)); 
                    }
                    //Dosyaya yazma işlemi
                    MatrisIslem.Yazdir(richTextBox1.Text);
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //dosyadan okuma butonu
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = MatrisIslem.Okuma();//dosyadan okuma işlemi
        }

        //tekrar işlem yapma
        private void tekrar_islem_Click(object sender, EventArgs e)
        {
            islemler_panel.Enabled = true;
            richTextBox1.Text = "";
            matrisBilgi.Text = "ilk Matris";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            boyut_panel.Enabled = true;
            degerGir.Enabled = false;
            matris_panel.Visible = true;
            boyut = 0; matris_sayi = 0; girdi_say = 0; islem_sira = 0;

            m1x1.Text = ""; m1x2.Text = ""; m1x3.Text = "";//textbox degerleri sıfırlanır
            m2x1.Text = ""; m2x2.Text = ""; m2x3.Text = "";
            m3x1.Text = ""; m3x2.Text = ""; m3x3.Text = "";
        }

        //islemler
        private void topla_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Matris Toplama\n";
            islem_no = 1;
            islemler_panel.Enabled = false;
            matris_sayi = 2;islem_sira++;
            
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void carp_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Matris Carpma\n";
            islem_no = 2;
            islemler_panel.Enabled = false;
            matris_sayi = 2; islem_sira++;
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void tersAl_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Matris Tersi Alma\n";
            islem_no = 3;
            islemler_panel.Enabled = false;
            matris_sayi = 1; islem_sira++;
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void izBul_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Matris izi bulma";
            islem_no = 4;
            islemler_panel.Enabled = false;
            matris_sayi = 1; islem_sira++;
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }

        private void transpoze_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Matris Transpozeu alma";
            islem_no = 5;
            islemler_panel.Enabled = false;
            matris_sayi = 1; islem_sira++;
            if (islem_sira == 2)
            {
                degerGir.Enabled = true;
            }
        }
    }
}
