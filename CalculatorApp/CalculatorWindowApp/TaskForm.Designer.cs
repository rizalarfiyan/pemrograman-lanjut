namespace CalculatorWindowApp
{
    partial class TaskForm
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
            this.operasi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNilaiA = new System.Windows.Forms.TextBox();
            this.inputNilaiB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hasil = new System.Windows.Forms.TextBox();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai B";
            // 
            // operasi
            // 
            this.operasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Tambah",
            "Kurang",
            "Kali",
            "Bagi",
            "Pangkat",
            "Modulo"});
            this.operasi.Location = new System.Drawing.Point(148, 36);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(305, 32);
            this.operasi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operasi";
            // 
            // inputNilaiA
            // 
            this.inputNilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNilaiA.Location = new System.Drawing.Point(148, 93);
            this.inputNilaiA.Name = "inputNilaiA";
            this.inputNilaiA.Size = new System.Drawing.Size(303, 29);
            this.inputNilaiA.TabIndex = 4;
            // 
            // inputNilaiB
            // 
            this.inputNilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNilaiB.Location = new System.Drawing.Point(150, 149);
            this.inputNilaiB.Name = "inputNilaiB";
            this.inputNilaiB.Size = new System.Drawing.Size(303, 29);
            this.inputNilaiB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasil";
            // 
            // hasil
            // 
            this.hasil.Enabled = false;
            this.hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil.Location = new System.Drawing.Point(150, 207);
            this.hasil.Name = "hasil";
            this.hasil.ReadOnly = true;
            this.hasil.Size = new System.Drawing.Size(303, 29);
            this.hasil.TabIndex = 7;
            // 
            // buttonHitung
            // 
            this.buttonHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHitung.Location = new System.Drawing.Point(328, 263);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(125, 39);
            this.buttonHitung.TabIndex = 8;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.UseVisualStyleBackColor = true;
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 339);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNilaiB);
            this.Controls.Add(this.inputNilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskForm";
            this.Text = "Aplikasi Kalkulator Versi Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNilaiA;
        private System.Windows.Forms.TextBox inputNilaiB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button buttonHitung;
    }
}