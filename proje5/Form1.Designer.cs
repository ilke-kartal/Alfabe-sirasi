namespace proje5
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
            this.cmbHarf = new System.Windows.Forms.ComboBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbHarf
            // 
            this.cmbHarf.FormattingEnabled = true;
            this.cmbHarf.Items.AddRange(new object[] {
            "A",
            "M",
            "B",
            "C",
            "Ç",
            "D",
            "E",
            "U",
            "F",
            "G",
            "Ğ",
            "H",
            "I",
            "İ",
            "J",
            "K",
            "L",
            "N",
            "O",
            "Ö",
            "Z",
            "P",
            "R",
            "S",
            "Ş",
            "T",
            "Ü",
            "V",
            "Y"});
            this.cmbHarf.Location = new System.Drawing.Point(300, 131);
            this.cmbHarf.Name = "cmbHarf";
            this.cmbHarf.Size = new System.Drawing.Size(121, 24);
            this.cmbHarf.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(311, 225);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "kontrol et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.cmbHarf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHarf;
        private System.Windows.Forms.Button btnKontrol;
    }
}

