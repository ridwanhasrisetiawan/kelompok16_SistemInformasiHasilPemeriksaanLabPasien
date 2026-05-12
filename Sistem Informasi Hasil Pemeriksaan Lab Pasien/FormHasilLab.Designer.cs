namespace Sistem_Informasi_Hasil_Pemeriksaan_Lab_Pasien
{
    partial class FormHasilLab
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
            this.btnView = new System.Windows.Forms.Button();
            this.dgvHasilLab = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasilLab)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(335, 379);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvHasilLab
            // 
            this.dgvHasilLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasilLab.Location = new System.Drawing.Point(105, 120);
            this.dgvHasilLab.Name = "dgvHasilLab";
            this.dgvHasilLab.RowHeadersWidth = 51;
            this.dgvHasilLab.RowTemplate.Height = 24;
            this.dgvHasilLab.Size = new System.Drawing.Size(570, 231);
            this.dgvHasilLab.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "HASIL LABORATORIUM";
            // 
            // FormHasilLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHasilLab);
            this.Controls.Add(this.btnView);
            this.Name = "FormHasilLab";
            this.Text = "FormHasilLab";
            this.Load += new System.EventHandler(this.FormHasilLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasilLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvHasilLab;
        private System.Windows.Forms.Label label1;
    }
}