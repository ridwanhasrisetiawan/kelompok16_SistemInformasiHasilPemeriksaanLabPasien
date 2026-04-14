namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    partial class FormDashboardDokter
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
            this.txtIDPeriksa = new System.Windows.Forms.TextBox();
            this.txtIDPasien = new System.Windows.Forms.TextBox();
            this.txtHasilLab = new System.Windows.Forms.TextBox();
            this.btnSIMPAN = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.btnCARI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEM LABORATORIUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "[ ID Periksa ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "[ ID Pasien ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "[ Hasil Lab ]";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtIDPeriksa
            // 
            this.txtIDPeriksa.Location = new System.Drawing.Point(157, 79);
            this.txtIDPeriksa.Name = "txtIDPeriksa";
            this.txtIDPeriksa.Size = new System.Drawing.Size(100, 22);
            this.txtIDPeriksa.TabIndex = 4;
            // 
            // txtIDPasien
            // 
            this.txtIDPasien.Location = new System.Drawing.Point(157, 120);
            this.txtIDPasien.Name = "txtIDPasien";
            this.txtIDPasien.Size = new System.Drawing.Size(100, 22);
            this.txtIDPasien.TabIndex = 5;
            // 
            // txtHasilLab
            // 
            this.txtHasilLab.Location = new System.Drawing.Point(157, 165);
            this.txtHasilLab.Name = "txtHasilLab";
            this.txtHasilLab.Size = new System.Drawing.Size(100, 22);
            this.txtHasilLab.TabIndex = 6;
            // 
            // btnSIMPAN
            // 
            this.btnSIMPAN.Location = new System.Drawing.Point(50, 219);
            this.btnSIMPAN.Name = "btnSIMPAN";
            this.btnSIMPAN.Size = new System.Drawing.Size(90, 36);
            this.btnSIMPAN.TabIndex = 7;
            this.btnSIMPAN.Text = "SIMPAN";
            this.btnSIMPAN.UseVisualStyleBackColor = true;
            this.btnSIMPAN.Click += new System.EventHandler(this.btnSIMPAN_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Location = new System.Drawing.Point(167, 219);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(90, 36);
            this.btnUPDATE.TabIndex = 8;
            this.btnUPDATE.Text = "UPDATE";
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Location = new System.Drawing.Point(289, 219);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(90, 36);
            this.btnHAPUS.TabIndex = 9;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // btnCARI
            // 
            this.btnCARI.Location = new System.Drawing.Point(406, 219);
            this.btnCARI.Name = "btnCARI";
            this.btnCARI.Size = new System.Drawing.Size(90, 36);
            this.btnCARI.TabIndex = 10;
            this.btnCARI.Text = "CARI";
            this.btnCARI.UseVisualStyleBackColor = true;
            this.btnCARI.Click += new System.EventHandler(this.btnCARI_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormDashboardDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCARI);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnSIMPAN);
            this.Controls.Add(this.txtHasilLab);
            this.Controls.Add(this.txtIDPasien);
            this.Controls.Add(this.txtIDPeriksa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboardDokter";
            this.Text = "FormDashboardDokter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDPeriksa;
        private System.Windows.Forms.TextBox txtIDPasien;
        private System.Windows.Forms.TextBox txtHasilLab;
        private System.Windows.Forms.Button btnSIMPAN;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Button btnCARI;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}