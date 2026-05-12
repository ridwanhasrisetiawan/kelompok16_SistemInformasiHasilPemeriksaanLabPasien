namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    partial class FormAdmin
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
            this.btnDataPasien = new System.Windows.Forms.Button();
            this.btnDataDokter = new System.Windows.Forms.Button();
            this.btnPemeriksaan = new System.Windows.Forms.Button();
            this.btnHasilLab = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBORD ADMIN";
            // 
            // btnDataPasien
            // 
            this.btnDataPasien.Location = new System.Drawing.Point(133, 109);
            this.btnDataPasien.Name = "btnDataPasien";
            this.btnDataPasien.Size = new System.Drawing.Size(111, 23);
            this.btnDataPasien.TabIndex = 1;
            this.btnDataPasien.Text = "Data Pasien";
            this.btnDataPasien.UseVisualStyleBackColor = true;
            this.btnDataPasien.Click += new System.EventHandler(this.btnDataPasien_Click);
            // 
            // btnDataDokter
            // 
            this.btnDataDokter.Location = new System.Drawing.Point(133, 164);
            this.btnDataDokter.Name = "btnDataDokter";
            this.btnDataDokter.Size = new System.Drawing.Size(111, 23);
            this.btnDataDokter.TabIndex = 2;
            this.btnDataDokter.Text = "Data Dokter";
            this.btnDataDokter.UseVisualStyleBackColor = true;
            this.btnDataDokter.Click += new System.EventHandler(this.btnDataDokter_Click);
            // 
            // btnPemeriksaan
            // 
            this.btnPemeriksaan.Location = new System.Drawing.Point(133, 216);
            this.btnPemeriksaan.Name = "btnPemeriksaan";
            this.btnPemeriksaan.Size = new System.Drawing.Size(127, 23);
            this.btnPemeriksaan.TabIndex = 3;
            this.btnPemeriksaan.Text = "Pemeriksaan Lab";
            this.btnPemeriksaan.UseVisualStyleBackColor = true;
            this.btnPemeriksaan.Click += new System.EventHandler(this.btnPemeriksaan_Click);
            // 
            // btnHasilLab
            // 
            this.btnHasilLab.Location = new System.Drawing.Point(133, 272);
            this.btnHasilLab.Name = "btnHasilLab";
            this.btnHasilLab.Size = new System.Drawing.Size(75, 23);
            this.btnHasilLab.TabIndex = 4;
            this.btnHasilLab.Text = "Hasil Lab";
            this.btnHasilLab.UseVisualStyleBackColor = true;
            this.btnHasilLab.Click += new System.EventHandler(this.btnHasilLab_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(133, 329);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHasilLab);
            this.Controls.Add(this.btnPemeriksaan);
            this.Controls.Add(this.btnDataDokter);
            this.Controls.Add(this.btnDataPasien);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDataPasien;
        private System.Windows.Forms.Button btnDataDokter;
        private System.Windows.Forms.Button btnPemeriksaan;
        private System.Windows.Forms.Button btnHasilLab;
        private System.Windows.Forms.Button btnLogout;
    }
}