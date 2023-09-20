namespace LatihanAutoLayout
{
    partial class Latihan
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textPesan1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNama = new TextBox();
            cmbPendidikan = new ComboBox();
            listPekerjaan = new ListBox();
            btnOk = new Button();
            textPesan3 = new TextBox();
            textPesan2 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textPesan1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 4);
            tableLayoutPanel1.Controls.Add(textPesan3, 0, 3);
            tableLayoutPanel1.Controls.Add(textPesan2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.19403F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.80597F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(463, 373);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textPesan1
            // 
            textPesan1.Dock = DockStyle.Fill;
            textPesan1.Enabled = false;
            textPesan1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan1.Location = new Point(3, 234);
            textPesan1.Name = "textPesan1";
            textPesan1.Size = new Size(457, 29);
            textPesan1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5813961F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.4186F));
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNama, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbPendidikan, 1, 1);
            tableLayoutPanel2.Controls.Add(listPekerjaan, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tableLayoutPanel2.Size = new Size(457, 225);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 1;
            label3.Text = "Pekerjaan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Pendidikan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 3;
            label1.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Dock = DockStyle.Fill;
            txtNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNama.Location = new Point(119, 3);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(335, 29);
            txtNama.TabIndex = 4;
            // 
            // cmbPendidikan
            // 
            cmbPendidikan.Dock = DockStyle.Fill;
            cmbPendidikan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPendidikan.FormattingEnabled = true;
            cmbPendidikan.Items.AddRange(new object[] { "SD", "SMP", "SMA", "Diploma", "Sarjana", "Pascasarjana" });
            cmbPendidikan.Location = new Point(119, 37);
            cmbPendidikan.Name = "cmbPendidikan";
            cmbPendidikan.Size = new Size(335, 29);
            cmbPendidikan.TabIndex = 5;
            // 
            // listPekerjaan
            // 
            listPekerjaan.Dock = DockStyle.Fill;
            listPekerjaan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listPekerjaan.FormattingEnabled = true;
            listPekerjaan.ItemHeight = 21;
            listPekerjaan.Items.AddRange(new object[] { "Pedagang", "PNS", "Dosen", "Swasta", "ABRI" });
            listPekerjaan.Location = new Point(119, 71);
            listPekerjaan.Name = "listPekerjaan";
            listPekerjaan.Size = new Size(335, 151);
            listPekerjaan.TabIndex = 6;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Fill;
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.Location = new Point(3, 340);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(457, 30);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // textPesan3
            // 
            textPesan3.Dock = DockStyle.Fill;
            textPesan3.Enabled = false;
            textPesan3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan3.Location = new Point(3, 305);
            textPesan3.Name = "textPesan3";
            textPesan3.Size = new Size(457, 29);
            textPesan3.TabIndex = 6;
            // 
            // textPesan2
            // 
            textPesan2.Dock = DockStyle.Fill;
            textPesan2.Enabled = false;
            textPesan2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPesan2.Location = new Point(3, 271);
            textPesan2.Name = "textPesan2";
            textPesan2.Size = new Size(457, 29);
            textPesan2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 373);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Latihan 3.3";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnOk;
        private TextBox textPesan3;
        private TextBox textPesan2;
        private TextBox textPesan1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNama;
        private ComboBox cmbPendidikan;
        private ListBox listPekerjaan;
    }
}