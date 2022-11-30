namespace odev2__matris
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topla = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.tersAl = new System.Windows.Forms.Button();
            this.izBul = new System.Windows.Forms.Button();
            this.transpoze = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.islemler_panel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.m1x1 = new System.Windows.Forms.TextBox();
            this.m3x1 = new System.Windows.Forms.TextBox();
            this.m1x2 = new System.Windows.Forms.TextBox();
            this.m2x2 = new System.Windows.Forms.TextBox();
            this.m3x2 = new System.Windows.Forms.TextBox();
            this.m3x3 = new System.Windows.Forms.TextBox();
            this.m2x1 = new System.Windows.Forms.TextBox();
            this.m2x3 = new System.Windows.Forms.TextBox();
            this.m1x3 = new System.Windows.Forms.TextBox();
            this.matrisBilgi = new System.Windows.Forms.Label();
            this.degerGir = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.matris_panel = new System.Windows.Forms.Panel();
            this.boyut_panel = new System.Windows.Forms.Panel();
            this.tekrar_islem = new System.Windows.Forms.Button();
            this.islemler_panel.SuspendLayout();
            this.matris_panel.SuspendLayout();
            this.boyut_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(4, 4);
            this.topla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(137, 28);
            this.topla.TabIndex = 0;
            this.topla.Text = "Topla";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // carp
            // 
            this.carp.Location = new System.Drawing.Point(4, 41);
            this.carp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(137, 28);
            this.carp.TabIndex = 1;
            this.carp.Text = "Çarp";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // tersAl
            // 
            this.tersAl.Location = new System.Drawing.Point(4, 78);
            this.tersAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tersAl.Name = "tersAl";
            this.tersAl.Size = new System.Drawing.Size(137, 28);
            this.tersAl.TabIndex = 2;
            this.tersAl.Text = "Tersini Al";
            this.tersAl.UseVisualStyleBackColor = true;
            this.tersAl.Click += new System.EventHandler(this.tersAl_Click);
            // 
            // izBul
            // 
            this.izBul.Location = new System.Drawing.Point(4, 114);
            this.izBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izBul.Name = "izBul";
            this.izBul.Size = new System.Drawing.Size(137, 28);
            this.izBul.TabIndex = 3;
            this.izBul.Text = "İzini Bul";
            this.izBul.UseVisualStyleBackColor = true;
            this.izBul.Click += new System.EventHandler(this.izBul_Click);
            // 
            // transpoze
            // 
            this.transpoze.Location = new System.Drawing.Point(4, 151);
            this.transpoze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transpoze.Name = "transpoze";
            this.transpoze.Size = new System.Drawing.Size(137, 28);
            this.transpoze.TabIndex = 4;
            this.transpoze.Text = "Transpoze Al";
            this.transpoze.UseVisualStyleBackColor = true;
            this.transpoze.Click += new System.EventHandler(this.transpoze_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 188);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "Dosyadan Oku";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // islemler_panel
            // 
            this.islemler_panel.Controls.Add(this.topla);
            this.islemler_panel.Controls.Add(this.button6);
            this.islemler_panel.Controls.Add(this.carp);
            this.islemler_panel.Controls.Add(this.transpoze);
            this.islemler_panel.Controls.Add(this.tersAl);
            this.islemler_panel.Controls.Add(this.izBul);
            this.islemler_panel.Location = new System.Drawing.Point(16, 15);
            this.islemler_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.islemler_panel.Name = "islemler_panel";
            this.islemler_panel.Size = new System.Drawing.Size(147, 223);
            this.islemler_panel.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(292, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(321, 489);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // m1x1
            // 
            this.m1x1.Location = new System.Drawing.Point(20, 369);
            this.m1x1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m1x1.Name = "m1x1";
            this.m1x1.Size = new System.Drawing.Size(36, 22);
            this.m1x1.TabIndex = 8;
            this.m1x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m3x1
            // 
            this.m3x1.Location = new System.Drawing.Point(0, 65);
            this.m3x1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m3x1.Name = "m3x1";
            this.m3x1.Size = new System.Drawing.Size(36, 22);
            this.m3x1.TabIndex = 9;
            this.m3x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m1x2
            // 
            this.m1x2.Location = new System.Drawing.Point(65, 369);
            this.m1x2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m1x2.Name = "m1x2";
            this.m1x2.Size = new System.Drawing.Size(36, 22);
            this.m1x2.TabIndex = 10;
            this.m1x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m2x2
            // 
            this.m2x2.Location = new System.Drawing.Point(65, 401);
            this.m2x2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2x2.Name = "m2x2";
            this.m2x2.Size = new System.Drawing.Size(36, 22);
            this.m2x2.TabIndex = 11;
            this.m2x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m3x2
            // 
            this.m3x2.Location = new System.Drawing.Point(45, 65);
            this.m3x2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m3x2.Name = "m3x2";
            this.m3x2.Size = new System.Drawing.Size(36, 22);
            this.m3x2.TabIndex = 12;
            this.m3x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m3x3
            // 
            this.m3x3.Location = new System.Drawing.Point(91, 65);
            this.m3x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m3x3.Name = "m3x3";
            this.m3x3.Size = new System.Drawing.Size(36, 22);
            this.m3x3.TabIndex = 13;
            this.m3x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m2x1
            // 
            this.m2x1.Location = new System.Drawing.Point(20, 401);
            this.m2x1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2x1.Name = "m2x1";
            this.m2x1.Size = new System.Drawing.Size(36, 22);
            this.m2x1.TabIndex = 14;
            this.m2x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.m2x1.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // m2x3
            // 
            this.m2x3.Location = new System.Drawing.Point(91, 33);
            this.m2x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m2x3.Name = "m2x3";
            this.m2x3.Size = new System.Drawing.Size(36, 22);
            this.m2x3.TabIndex = 16;
            this.m2x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m1x3
            // 
            this.m1x3.Location = new System.Drawing.Point(91, 1);
            this.m1x3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m1x3.Name = "m1x3";
            this.m1x3.Size = new System.Drawing.Size(36, 22);
            this.m1x3.TabIndex = 15;
            this.m1x3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrisBilgi
            // 
            this.matrisBilgi.AutoSize = true;
            this.matrisBilgi.Location = new System.Drawing.Point(180, 405);
            this.matrisBilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matrisBilgi.Name = "matrisBilgi";
            this.matrisBilgi.Size = new System.Drawing.Size(62, 17);
            this.matrisBilgi.TabIndex = 17;
            this.matrisBilgi.Text = "A matrisi";
            // 
            // degerGir
            // 
            this.degerGir.Enabled = false;
            this.degerGir.Location = new System.Drawing.Point(32, 476);
            this.degerGir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.degerGir.Name = "degerGir";
            this.degerGir.Size = new System.Drawing.Size(100, 28);
            this.degerGir.TabIndex = 18;
            this.degerGir.Text = "Değer gir";
            this.degerGir.UseVisualStyleBackColor = true;
            this.degerGir.Click += new System.EventHandler(this.degerGir_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 4);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 21);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3x3";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 32);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 21);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2x2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Boyut seç";
            // 
            // matris_panel
            // 
            this.matris_panel.Controls.Add(this.m3x1);
            this.matris_panel.Controls.Add(this.m3x2);
            this.matris_panel.Controls.Add(this.m3x3);
            this.matris_panel.Controls.Add(this.m1x3);
            this.matris_panel.Controls.Add(this.m2x3);
            this.matris_panel.Location = new System.Drawing.Point(20, 369);
            this.matris_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matris_panel.Name = "matris_panel";
            this.matris_panel.Size = new System.Drawing.Size(132, 94);
            this.matris_panel.TabIndex = 22;
            // 
            // boyut_panel
            // 
            this.boyut_panel.Controls.Add(this.radioButton1);
            this.boyut_panel.Controls.Add(this.radioButton2);
            this.boyut_panel.Location = new System.Drawing.Point(44, 270);
            this.boyut_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boyut_panel.Name = "boyut_panel";
            this.boyut_panel.Size = new System.Drawing.Size(67, 60);
            this.boyut_panel.TabIndex = 23;
            // 
            // tekrar_islem
            // 
            this.tekrar_islem.Location = new System.Drawing.Point(228, 534);
            this.tekrar_islem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tekrar_islem.Name = "tekrar_islem";
            this.tekrar_islem.Size = new System.Drawing.Size(145, 58);
            this.tekrar_islem.TabIndex = 24;
            this.tekrar_islem.Text = "Tekrar İşlem Yap";
            this.tekrar_islem.UseVisualStyleBackColor = true;
            this.tekrar_islem.Click += new System.EventHandler(this.tekrar_islem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(631, 609);
            this.Controls.Add(this.tekrar_islem);
            this.Controls.Add(this.m2x1);
            this.Controls.Add(this.m2x2);
            this.Controls.Add(this.m1x2);
            this.Controls.Add(this.m1x1);
            this.Controls.Add(this.matris_panel);
            this.Controls.Add(this.boyut_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degerGir);
            this.Controls.Add(this.matrisBilgi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.islemler_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.islemler_panel.ResumeLayout(false);
            this.matris_panel.ResumeLayout(false);
            this.matris_panel.PerformLayout();
            this.boyut_panel.ResumeLayout(false);
            this.boyut_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button tersAl;
        private System.Windows.Forms.Button izBul;
        private System.Windows.Forms.Button transpoze;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel islemler_panel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox m1x1;
        private System.Windows.Forms.TextBox m3x1;
        private System.Windows.Forms.TextBox m1x2;
        private System.Windows.Forms.TextBox m2x2;
        private System.Windows.Forms.TextBox m3x2;
        private System.Windows.Forms.TextBox m3x3;
        private System.Windows.Forms.TextBox m2x1;
        private System.Windows.Forms.TextBox m2x3;
        private System.Windows.Forms.TextBox m1x3;
        private System.Windows.Forms.Label matrisBilgi;
        private System.Windows.Forms.Button degerGir;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel matris_panel;
        private System.Windows.Forms.Panel boyut_panel;
        private System.Windows.Forms.Button tekrar_islem;
    }
}

