namespace Calisma2
{
    partial class tekCift
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
            this.grp_TekCift = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Ekle = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.lbox_Ekle = new System.Windows.Forms.ListBox();
            this.btn_Kaldir = new System.Windows.Forms.Button();
            this.grp_SayiEkleme = new System.Windows.Forms.GroupBox();
            this.btn_FormDegistir = new System.Windows.Forms.Button();
            this.grp_TekCift.SuspendLayout();
            this.grp_SayiEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_TekCift
            // 
            this.grp_TekCift.Controls.Add(this.button1);
            this.grp_TekCift.Controls.Add(this.textBox1);
            this.grp_TekCift.Location = new System.Drawing.Point(11, 12);
            this.grp_TekCift.Name = "grp_TekCift";
            this.grp_TekCift.Size = new System.Drawing.Size(250, 129);
            this.grp_TekCift.TabIndex = 0;
            this.grp_TekCift.TabStop = false;
            this.grp_TekCift.Text = "Tek mi Çift mi ?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tek mi çift mi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 27);
            this.textBox1.TabIndex = 0;
            // 
            // txt_Ekle
            // 
            this.txt_Ekle.Location = new System.Drawing.Point(24, 26);
            this.txt_Ekle.Name = "txt_Ekle";
            this.txt_Ekle.Size = new System.Drawing.Size(351, 27);
            this.txt_Ekle.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(24, 59);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(351, 29);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // lbox_Ekle
            // 
            this.lbox_Ekle.FormattingEnabled = true;
            this.lbox_Ekle.ItemHeight = 20;
            this.lbox_Ekle.Location = new System.Drawing.Point(24, 94);
            this.lbox_Ekle.Name = "lbox_Ekle";
            this.lbox_Ekle.Size = new System.Drawing.Size(351, 344);
            this.lbox_Ekle.TabIndex = 3;
            // 
            // btn_Kaldir
            // 
            this.btn_Kaldir.Location = new System.Drawing.Point(58, 729);
            this.btn_Kaldir.Name = "btn_Kaldir";
            this.btn_Kaldir.Size = new System.Drawing.Size(351, 29);
            this.btn_Kaldir.TabIndex = 4;
            this.btn_Kaldir.Text = "Seçimi Kaldır";
            this.btn_Kaldir.UseVisualStyleBackColor = true;
            this.btn_Kaldir.Click += new System.EventHandler(this.btn_Kaldir_Click);
            // 
            // grp_SayiEkleme
            // 
            this.grp_SayiEkleme.Controls.Add(this.btn_Ekle);
            this.grp_SayiEkleme.Controls.Add(this.txt_Ekle);
            this.grp_SayiEkleme.Controls.Add(this.lbox_Ekle);
            this.grp_SayiEkleme.Location = new System.Drawing.Point(294, 12);
            this.grp_SayiEkleme.Name = "grp_SayiEkleme";
            this.grp_SayiEkleme.Size = new System.Drawing.Size(392, 456);
            this.grp_SayiEkleme.TabIndex = 5;
            this.grp_SayiEkleme.TabStop = false;
            this.grp_SayiEkleme.Text = "Girilen Sayı Ekleme";
            // 
            // btn_FormDegistir
            // 
            this.btn_FormDegistir.Location = new System.Drawing.Point(11, 149);
            this.btn_FormDegistir.Name = "btn_FormDegistir";
            this.btn_FormDegistir.Size = new System.Drawing.Size(250, 301);
            this.btn_FormDegistir.TabIndex = 6;
            this.btn_FormDegistir.Text = "DİĞER PROGRAMA GEÇ";
            this.btn_FormDegistir.UseVisualStyleBackColor = true;
            this.btn_FormDegistir.Click += new System.EventHandler(this.btn_FormDegistir_Click);
            // 
            // tekCift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 489);
            this.Controls.Add(this.btn_FormDegistir);
            this.Controls.Add(this.grp_SayiEkleme);
            this.Controls.Add(this.btn_Kaldir);
            this.Controls.Add(this.grp_TekCift);
            this.Name = "tekCift";
            this.Text = "tekCift";
            this.Load += new System.EventHandler(this.tekCift_Load);
            this.grp_TekCift.ResumeLayout(false);
            this.grp_TekCift.PerformLayout();
            this.grp_SayiEkleme.ResumeLayout(false);
            this.grp_SayiEkleme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp_TekCift;
        private Button button1;
        private TextBox textBox1;
        private TextBox txt_Ekle;
        private Button btn_Ekle;
        private ListBox lbox_Ekle;
        private Button btn_Kaldir;
        private GroupBox grp_SayiEkleme;
        private Button btn_FormDegistir;
    }
}