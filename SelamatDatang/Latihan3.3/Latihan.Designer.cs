namespace Latihan3._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNama = new TextBox();
            cmbPendidikan = new ComboBox();
            listPekerjaan = new ListBox();
            textPesan1 = new TextBox();
            textPesan2 = new TextBox();
            textPesan3 = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 0;
            label2.Text = "Pendidikan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 0;
            label3.Text = "Pekerjaan";
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(160, 35);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(265, 29);
            txtNama.TabIndex = 1;
            // 
            // cmbPendidikan
            // 
            cmbPendidikan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPendidikan.FormattingEnabled = true;
            cmbPendidikan.Items.AddRange(new object[] { "SD", "SMP", "SMA", "Diploma", "Sarjana", "Pascasarjana" });
            cmbPendidikan.Location = new Point(160, 76);
            cmbPendidikan.Name = "cmbPendidikan";
            cmbPendidikan.Size = new Size(265, 29);
            cmbPendidikan.TabIndex = 2;
            // 
            // listPekerjaan
            // 
            listPekerjaan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listPekerjaan.FormattingEnabled = true;
            listPekerjaan.ItemHeight = 21;
            listPekerjaan.Items.AddRange(new object[] { "Pedagang", "PNS", "Dosen", "Swasta", "ABRI" });
            listPekerjaan.Location = new Point(157, 124);
            listPekerjaan.Name = "listPekerjaan";
            listPekerjaan.Size = new Size(269, 109);
            listPekerjaan.TabIndex = 3;
            // 
            // textPesan1
            // 
            textPesan1.Enabled = false;
            textPesan1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan1.Location = new Point(22, 248);
            textPesan1.Name = "textPesan1";
            textPesan1.Size = new Size(403, 29);
            textPesan1.TabIndex = 1;
            // 
            // textPesan2
            // 
            textPesan2.Enabled = false;
            textPesan2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan2.Location = new Point(22, 283);
            textPesan2.Name = "textPesan2";
            textPesan2.Size = new Size(403, 29);
            textPesan2.TabIndex = 1;
            // 
            // textPesan3
            // 
            textPesan3.Enabled = false;
            textPesan3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan3.Location = new Point(22, 318);
            textPesan3.Name = "textPesan3";
            textPesan3.Size = new Size(403, 29);
            textPesan3.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(22, 363);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(403, 33);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 421);
            Controls.Add(btnOk);
            Controls.Add(listPekerjaan);
            Controls.Add(cmbPendidikan);
            Controls.Add(textPesan3);
            Controls.Add(textPesan2);
            Controls.Add(textPesan1);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Latihan 3.3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNama;
        private ComboBox cmbPendidikan;
        private ListBox listPekerjaan;
        private TextBox textPesan1;
        private TextBox textPesan2;
        private TextBox textPesan3;
        private Button btnOk;
    }
}