namespace SifreOlusturma2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_k_harf_sayisi = new System.Windows.Forms.TextBox();
            this.txt_b_harf_sayisi = new System.Windows.Forms.TextBox();
            this.txt_rakam_sayisi = new System.Windows.Forms.TextBox();
            this.txt_kucuk_harfler = new System.Windows.Forms.TextBox();
            this.txt_buyuk_harfler = new System.Windows.Forms.TextBox();
            this.txt_rakamlar = new System.Windows.Forms.TextBox();
            this.btn_sifre_uret = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Küçük Harf Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Büyük Harf Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rakam Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(285, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Karakter Aralığı";
            // 
            // txt_k_harf_sayisi
            // 
            this.txt_k_harf_sayisi.Location = new System.Drawing.Point(155, 31);
            this.txt_k_harf_sayisi.Name = "txt_k_harf_sayisi";
            this.txt_k_harf_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_k_harf_sayisi.TabIndex = 4;
            this.txt_k_harf_sayisi.Text = "2";
            // 
            // txt_b_harf_sayisi
            // 
            this.txt_b_harf_sayisi.Location = new System.Drawing.Point(155, 57);
            this.txt_b_harf_sayisi.Name = "txt_b_harf_sayisi";
            this.txt_b_harf_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_b_harf_sayisi.TabIndex = 5;
            this.txt_b_harf_sayisi.Text = "4";
            // 
            // txt_rakam_sayisi
            // 
            this.txt_rakam_sayisi.Location = new System.Drawing.Point(155, 83);
            this.txt_rakam_sayisi.Name = "txt_rakam_sayisi";
            this.txt_rakam_sayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_rakam_sayisi.TabIndex = 6;
            this.txt_rakam_sayisi.Text = "2";
            // 
            // txt_kucuk_harfler
            // 
            this.txt_kucuk_harfler.Location = new System.Drawing.Point(288, 32);
            this.txt_kucuk_harfler.Name = "txt_kucuk_harfler";
            this.txt_kucuk_harfler.Size = new System.Drawing.Size(212, 20);
            this.txt_kucuk_harfler.TabIndex = 7;
            this.txt_kucuk_harfler.Text = "mustafabükülmez";
            // 
            // txt_buyuk_harfler
            // 
            this.txt_buyuk_harfler.Location = new System.Drawing.Point(288, 59);
            this.txt_buyuk_harfler.Name = "txt_buyuk_harfler";
            this.txt_buyuk_harfler.Size = new System.Drawing.Size(212, 20);
            this.txt_buyuk_harfler.TabIndex = 8;
            this.txt_buyuk_harfler.Text = "MUSTAFABÜKÜLMEZ";
            // 
            // txt_rakamlar
            // 
            this.txt_rakamlar.Location = new System.Drawing.Point(288, 85);
            this.txt_rakamlar.Name = "txt_rakamlar";
            this.txt_rakamlar.Size = new System.Drawing.Size(212, 20);
            this.txt_rakamlar.TabIndex = 9;
            this.txt_rakamlar.Text = "16160";
            // 
            // btn_sifre_uret
            // 
            this.btn_sifre_uret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifre_uret.Location = new System.Drawing.Point(14, 118);
            this.btn_sifre_uret.Name = "btn_sifre_uret";
            this.btn_sifre_uret.Size = new System.Drawing.Size(486, 28);
            this.btn_sifre_uret.TabIndex = 10;
            this.btn_sifre_uret.Text = "Şifre Üret";
            this.btn_sifre_uret.UseVisualStyleBackColor = true;
            this.btn_sifre_uret.Click += new System.EventHandler(this.btn_sifre_uret_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(155, 165);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(345, 20);
            this.txt_sifre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Üretilen Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.btn_sifre_uret);
            this.Controls.Add(this.txt_rakamlar);
            this.Controls.Add(this.txt_buyuk_harfler);
            this.Controls.Add(this.txt_kucuk_harfler);
            this.Controls.Add(this.txt_rakam_sayisi);
            this.Controls.Add(this.txt_b_harf_sayisi);
            this.Controls.Add(this.txt_k_harf_sayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_k_harf_sayisi;
        private System.Windows.Forms.TextBox txt_b_harf_sayisi;
        private System.Windows.Forms.TextBox txt_rakam_sayisi;
        private System.Windows.Forms.TextBox txt_kucuk_harfler;
        private System.Windows.Forms.TextBox txt_buyuk_harfler;
        private System.Windows.Forms.TextBox txt_rakamlar;
        private System.Windows.Forms.Button btn_sifre_uret;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label5;
    }
}

