namespace week12_veritabani_2
{
    partial class SiparisGoruntule
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
            this.txtSiparisDetay = new System.Windows.Forms.RichTextBox();
            this.listeSiparisler = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.belge = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // txtSiparisDetay
            // 
            this.txtSiparisDetay.Location = new System.Drawing.Point(237, 37);
            this.txtSiparisDetay.Name = "txtSiparisDetay";
            this.txtSiparisDetay.Size = new System.Drawing.Size(551, 241);
            this.txtSiparisDetay.TabIndex = 0;
            this.txtSiparisDetay.Text = "";
            // 
            // listeSiparisler
            // 
            this.listeSiparisler.FormattingEnabled = true;
            this.listeSiparisler.Location = new System.Drawing.Point(12, 37);
            this.listeSiparisler.Name = "listeSiparisler";
            this.listeSiparisler.Size = new System.Drawing.Size(205, 238);
            this.listeSiparisler.TabIndex = 1;
            this.listeSiparisler.SelectedIndexChanged += new System.EventHandler(this.listeSiparisler_SelectedIndexChanged);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(12, 284);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(776, 42);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sipariş Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sipariş Detayı";
            // 
            // belge
            // 
            this.belge.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.belge_PrintPage);
            // 
            // SiparisGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.listeSiparisler);
            this.Controls.Add(this.txtSiparisDetay);
            this.Name = "SiparisGoruntule";
            this.Text = "Sipariş Görüntüle";
            this.Load += new System.EventHandler(this.SiparisGoruntule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSiparisDetay;
        private System.Windows.Forms.ListBox listeSiparisler;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument belge;
    }
}