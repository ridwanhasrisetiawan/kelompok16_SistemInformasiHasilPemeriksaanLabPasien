namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    partial class FormPasien
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
            this.dgvHasil = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBORD PASIEN";
            // 
            // dgvHasil
            // 
            this.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasil.Location = new System.Drawing.Point(110, 153);
            this.dgvHasil.Name = "dgvHasil";
            this.dgvHasil.RowHeadersWidth = 51;
            this.dgvHasil.RowTemplate.Height = 24;
            this.dgvHasil.Size = new System.Drawing.Size(556, 150);
            this.dgvHasil.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(110, 116);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 31);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(676, 389);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(88, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCetak
            // 
            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCetak.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(591, 389);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 38);
            this.btnCetak.TabIndex = 4;
            this.btnCetak.Text = "Cetak Kontol";
            this.btnCetak.UseVisualStyleBackColor = false;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvHasil);
            this.Controls.Add(this.label1);
            this.Name = "FormPasien";
            this.Text = "FormPasien";
            this.Load += new System.EventHandler(this.FormPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHasil;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCetak;
    }
}