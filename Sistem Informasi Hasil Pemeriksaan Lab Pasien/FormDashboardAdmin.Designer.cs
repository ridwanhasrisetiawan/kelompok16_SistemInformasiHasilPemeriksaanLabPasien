namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    partial class FormDashboardAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId_Pasien = new System.Windows.Forms.TextBox();
            this.txtId_Dokter = new System.Windows.Forms.TextBox();
            this.txtPeriksa = new System.Windows.Forms.TextBox();
            this.txtHasilLab = new System.Windows.Forms.TextBox();
            this.dgvPasien = new System.Windows.Forms.DataGridView();
            this.dgvPemeriksaan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemeriksaan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelola Data Pasien dan Pemeriksaan Laboratorium";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(480, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "HAPUS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(531, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Tambah Pasien";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(425, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "REFRESH";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(318, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "SIMPAN";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(642, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "CARI";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(39, 92);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Pasien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID Dokter";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(39, 243);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasil Laboratorium";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtId_Pasien
            // 
            this.txtId_Pasien.Location = new System.Drawing.Point(130, 157);
            this.txtId_Pasien.Name = "txtId_Pasien";
            this.txtId_Pasien.Size = new System.Drawing.Size(100, 22);
            this.txtId_Pasien.TabIndex = 15;
            this.txtId_Pasien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtId_Dokter
            // 
            this.txtId_Dokter.Location = new System.Drawing.Point(130, 198);
            this.txtId_Dokter.Name = "txtId_Dokter";
            this.txtId_Dokter.Size = new System.Drawing.Size(100, 22);
            this.txtId_Dokter.TabIndex = 16;
            // 
            // txtPeriksa
            // 
            this.txtPeriksa.Location = new System.Drawing.Point(259, 157);
            this.txtPeriksa.Name = "txtPeriksa";
            this.txtPeriksa.Size = new System.Drawing.Size(49, 22);
            this.txtPeriksa.TabIndex = 17;
            // 
            // txtHasilLab
            // 
            this.txtHasilLab.Location = new System.Drawing.Point(356, 117);
            this.txtHasilLab.Multiline = true;
            this.txtHasilLab.Name = "txtHasilLab";
            this.txtHasilLab.Size = new System.Drawing.Size(361, 45);
            this.txtHasilLab.TabIndex = 18;
            this.txtHasilLab.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvPasien
            // 
            this.dgvPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasien.Location = new System.Drawing.Point(386, 321);
            this.dgvPasien.Name = "dgvPasien";
            this.dgvPasien.RowHeadersWidth = 51;
            this.dgvPasien.RowTemplate.Height = 24;
            this.dgvPasien.Size = new System.Drawing.Size(361, 122);
            this.dgvPasien.TabIndex = 19;
            // 
            // dgvPemeriksaan
            // 
            this.dgvPemeriksaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPemeriksaan.Location = new System.Drawing.Point(19, 321);
            this.dgvPemeriksaan.Name = "dgvPemeriksaan";
            this.dgvPemeriksaan.RowHeadersWidth = 51;
            this.dgvPemeriksaan.RowTemplate.Height = 24;
            this.dgvPemeriksaan.Size = new System.Drawing.Size(361, 122);
            this.dgvPemeriksaan.TabIndex = 20;
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPemeriksaan);
            this.Controls.Add(this.dgvPasien);
            this.Controls.Add(this.txtHasilLab);
            this.Controls.Add(this.txtPeriksa);
            this.Controls.Add(this.txtId_Dokter);
            this.Controls.Add(this.txtId_Pasien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboardAdmin";
            this.Text = "FormDashboardAdmin";
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemeriksaan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId_Pasien;
        private System.Windows.Forms.TextBox txtId_Dokter;
        private System.Windows.Forms.TextBox txtPeriksa;
        private System.Windows.Forms.TextBox txtHasilLab;
        private System.Windows.Forms.DataGridView dgvPasien;
        private System.Windows.Forms.DataGridView dgvPemeriksaan;
    }
}