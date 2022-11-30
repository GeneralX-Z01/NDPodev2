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
namespace soru2_
{
    public partial class Form1 : Form
    {
        private int islem_numarasi = 0;
        private int matris_islem = 0;
        private string yazilacak = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void tekrar_button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            tekrar_button1.Enabled = false;
            matris1_groupBox1.Enabled = false;
            matris2_groupBox1.Enabled = false;
            sonuc_groupBox1.Enabled = false;
            label1.Enabled = false;
            islemler_groupBox1.Enabled = true;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            button7.Enabled = false;
            label1.Text = "sonuc";
            matris_islem = 0;
            boyut_button1.Enabled = false;
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = "";textBox7.Text = ""; textBox8.Text = ""; textBox9.Text = "";textBox10.Text = ""; textBox11.Text = ""; textBox12.Text = "";textBox13.Text = ""; textBox14.Text = ""; textBox15.Text = "";textBox16.Text = ""; textBox17.Text = ""; textBox18.Text = "";textBox19.Text = ""; textBox20.Text = ""; textBox21.Text = "";textBox22.Text = ""; textBox23.Text = ""; textBox24.Text = "";textBox25.Text = ""; textBox26.Text = ""; textBox27.Text = "";
        }

        private void degerAl(object sender, EventArgs e)
        {
            TextBox[] array1 = { textBox1, textBox2, textBox3, textBox6, textBox5, textBox4, textBox9, textBox8, textBox7 };
            TextBox[] array2 = { textBox18, textBox17, textBox16, textBox15, textBox14, textBox13, textBox12, textBox11, textBox10 };
            TextBox[] array3 = { textBox27, textBox26, textBox25, textBox24, textBox23, textBox22, textBox21, textBox20, textBox19 };//texboxlar diziye dönüştürülür

            double[,] matris1 = new double[Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value)];
            double[,] matris2 = new double[Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown1.Value)];//gerekli boyutta matrisler oluşturulur

            for (int i = 0; i < 9; i++)//boş bırakılan deger varsa 0 atanır
            {
                if (array1[i].Text == "")
                {
                    array1[i].Text = "0";
                }
                if (array2[i].Text == "" && matris_islem==2)
                {
                    array2[i].Text = "0";
                }
            }
            int dizi_index = 0;
            yazilacak = yazilacak + "matris 1\n";
            for (int i = 0; i < matris1.GetLength(0); i++)
            {
                for (int j = 0; j < matris1.GetLength(0); j++)
                {
                    if(numericUpDown1.Value==3)
                    {
                        matris1[i, j] = Convert.ToDouble(array1[dizi_index].Text);
                        yazilacak = yazilacak + matris1[i, j] + "   ";//yazma işleminde kullanılacak değişkene matris1 degerleri eklenir
                    }
                    else if(numericUpDown1.Value==2)//boyut 2 olması durumu
                    {
                        if(dizi_index==2)
                        {
                            dizi_index++;
                        }
                        matris1[i, j] = Convert.ToDouble(array1[dizi_index].Text);
                        yazilacak = yazilacak + matris1[i, j] + "   ";//yazma işleminde kullanılacak değişkene matris1 degerleri eklenir
                    }
                    dizi_index++;
                }
                yazilacak = yazilacak + "\n";
            }
            if (matris_islem == 2)
            {
                dizi_index = 0;
                yazilacak = yazilacak + "matris 2\n";
                for (int i = 0; i < matris2.GetLength(0); i++)
                {
                    for (int j = 0; j < matris2.GetLength(0); j++)
                    {
                        if (numericUpDown1.Value == 3)
                        {
                            matris2[i, j] = Convert.ToDouble(array2[dizi_index].Text);
                            yazilacak = yazilacak + matris2[i, j] + "   ";//yazma işleminde kullanılacak değişkene matris2 degerleri eklenir
                        }
                        else if (numericUpDown1.Value == 2)//boyut 2 olması durumu
                        {
                            if (dizi_index == 2)
                            {
                                dizi_index++;
                            }
                            matris2[i, j] = Convert.ToDouble(array2[dizi_index].Text);
                            yazilacak = yazilacak + matris2[i, j] + "   ";//yazma işleminde kullanılacak değişkene matris2 degerleri eklenir
                        }
                        dizi_index++;
                    }
                    yazilacak = yazilacak + "\n";
                }
            }
            yazilacak = yazilacak + "sonuc\n";
            tekrar_button1.Enabled = true;
            button7.Enabled = false;
            

            //deger girme işlemi bittikten sonra hesaplama işlemi için gerekli olan fonklar çağrilir
            if (islem_numarasi == 1)
            {
                double[,] cevap = MatrisIslem.Toplama(matris1, matris2);
                int index = 0;
                for (int i = 0; i < matris1.GetLength(0); i++)
                {
                    for (int j = 0; j < matris1.GetLength(0); j++)
                    {
                        if(numericUpDown1.Value==2&&index==2)
                        {
                           index++;
                        }
                        array3[index].Text = Convert.ToString(cevap[i, j]);
                        yazilacak = yazilacak + array3[index].Text + "   ";//cevap matrisi yazilacak stringe eklenir
                        index++;
                    }
                    yazilacak = yazilacak + "\n";
                }
            }
            else if (islem_numarasi == 2)
            {
                double[,] cevap = MatrisIslem.Carpma(matris1, matris2);
                int index = 0;
                for (int i = 0; i < matris1.GetLength(0); i++)
                {
                    for (int j = 0; j < matris1.GetLength(0); j++)
                    {
                        if (numericUpDown1.Value == 2 && index == 2)
                        {
                            index++;
                        }
                        array3[index].Text = Convert.ToString(cevap[i, j]);
                        yazilacak = yazilacak + array3[index].Text + "   ";//cevap matrisi yazilacak stringe eklenir
                        index++;
                    }
                    yazilacak = yazilacak + "\n";
                }
            }
            else if (islem_numarasi == 3)
            {
                var tuple = MatrisIslem.TersAl(matris1);
                double det = tuple.Item1;
                if (det != 0)
                {
                    double[,] cevap = tuple.Item2;
                    int index = 0;
                    for (int i = 0; i < cevap.GetLength(0); i++)
                    {
                        for (int j = 0; j < cevap.GetLength(0); j++)
                        {
                            if(numericUpDown1.Value == 2 && index == 2)
                            {
                                index++;
                            }
                            array3[index].Text = Convert.ToString(cevap[i, j]);
                            yazilacak = yazilacak + array3[index].Text + "   ";//cevap matrisi yazilacak stringe eklenir
                            index++;
                        }
                        yazilacak = yazilacak + "\n";
                    }
                }
                else
                {
                    label1.Enabled = true;
                    sonuc_groupBox1.Enabled = false;
                    label1.Text = "Bu matrisin tersi alınamaz (det=0)";
                    yazilacak = yazilacak + "Bu matrisin tersi alinamaz. Determinant degeri=0\n";//det sıfır olması durumunda cevap olarak bu ifade dosyaya yazdırılır
                }
            }
            else if (islem_numarasi == 4)
            {
                double cevap = MatrisIslem.IzBul(matris1);
                label1.Text = Convert.ToString(cevap);
                yazilacak = yazilacak + cevap + "\n";
            }
            else if (islem_numarasi == 5)
            {
                double[,] cevap = MatrisIslem.Transpoze(matris1);
                int index = 0;
                for (int i = 0; i < cevap.GetLength(0); i++)
                {
                    for (int j = 0; j < cevap.GetLength(0); j++)
                    {
                        if (numericUpDown1.Value == 2 && index == 2)
                        {
                            index++;
                        }
                        array3[index].Text = Convert.ToString(cevap[i, j]);
                        yazilacak = yazilacak + array3[index].Text + "   ";
                        index++;
                    }
                    yazilacak = yazilacak + "\n";//cevap matrisi yazilacak stringe eklenir
                }
            }
            MatrisIslem.Yazdir(yazilacak);
        }

        private void toplabutton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            islemler_groupBox1.Enabled = false;
            islem_numarasi = 1;
            matris_islem = 2;
            yazilacak = "Matris Toplama\n";
            boyut_button1.Enabled = true;
        }

        private void carpbutton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            islemler_groupBox1.Enabled = false;
            islem_numarasi = 2;
            matris_islem = 2;
            yazilacak = "Matris Carpma\n";
            boyut_button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            matris_islem = 1;
            islemler_groupBox1.Enabled = false;
            islem_numarasi = 3;
            yazilacak = "Matris Tersi Alma\n";
            boyut_button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            matris1_groupBox1.Enabled = true;
            matris2_groupBox1.Enabled = false;
            sonuc_groupBox1.Enabled = false;
            label1.Enabled = true;
            islemler_groupBox1.Enabled = false;
            islem_numarasi = 4;
            yazilacak = "Matris Izi Bulma\n";
            boyut_button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            
            matris_islem = 1;
            matris2_groupBox1.Enabled = false;
            islemler_groupBox1.Enabled = false;
            islem_numarasi = 5;
            yazilacak = "Matris Transpoze hesaplama\n";
            boyut_button1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button7.Enabled = false;
            tekrar_button1.Enabled = true;
            richTextBox1.Text = MatrisIslem.Okuma();
            boyut_button1.Enabled = false;
        }

        private void boyut_button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            button7.Enabled = true;
            if (numericUpDown1.Value==2)
            {
                textBox3.Visible = false;textBox4.Visible = false;textBox7.Visible = false;textBox8.Visible = false;textBox9.Visible = false;
                textBox16.Visible = false;textBox13.Visible = false;textBox10.Visible = false;textBox11.Visible = false;textBox12.Visible = false;
                textBox25.Visible = false;textBox22.Visible = false;textBox19.Visible = false;textBox20.Visible = false;textBox21.Visible = false;
            }
            else
            {
                textBox3.Visible = true; textBox4.Visible = true; textBox7.Visible = true; textBox8.Visible = true; textBox9.Visible = true;
                textBox16.Visible = true; textBox13.Visible = true; textBox10.Visible = true; textBox11.Visible = true; textBox12.Visible = true;
                textBox25.Visible = true; textBox22.Visible = true; textBox19.Visible = true; textBox20.Visible = true; textBox21.Visible = true;
            }
            boyut_button1.Enabled = false;
            if (matris_islem == 2)
            {
                matris1_groupBox1.Enabled = true;
                matris2_groupBox1.Enabled = true;
                sonuc_groupBox1.Enabled = true;
            }
            else if(matris_islem==1)
            {
                matris1_groupBox1.Enabled = true;
                sonuc_groupBox1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
