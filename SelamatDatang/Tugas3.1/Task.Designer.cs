namespace Tugas3._1
{
    partial class Task
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
            btnKosongkan = new Button();
            btnTampilkan = new Button();
            label1 = new Label();
            lblNIM = new Label();
            label3 = new Label();
            lblNama = new Label();
            label5 = new Label();
            lblKelas = new Label();
            SuspendLayout();
            // 
            // btnKosongkan
            // 
            btnKosongkan.Location = new Point(247, 145);
            btnKosongkan.Name = "btnKosongkan";
            btnKosongkan.Size = new Size(111, 28);
            btnKosongkan.TabIndex = 2;
            btnKosongkan.Text = "Kosongkan";
            btnKosongkan.UseVisualStyleBackColor = true;
            btnKosongkan.Click += btnKosongkan_Click;
            // 
            // btnTampilkan
            // 
            btnTampilkan.Location = new Point(130, 145);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(111, 28);
            btnTampilkan.TabIndex = 3;
            btnTampilkan.Text = "Tampilkan";
            btnTampilkan.UseVisualStyleBackColor = true;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 4;
            label1.Text = "NIM         :";
            // 
            // lblNIM
            // 
            lblNIM.AutoSize = true;
            lblNIM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNIM.Location = new Point(121, 40);
            lblNIM.Name = "lblNIM";
            lblNIM.Size = new Size(14, 21);
            lblNIM.TabIndex = 4;
            lblNIM.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 70);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Nama      :";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNama.Location = new Point(121, 70);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(14, 21);
            lblNama.TabIndex = 4;
            lblNama.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 98);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 4;
            label5.Text = "Kelas       :";
            // 
            // lblKelas
            // 
            lblKelas.AutoSize = true;
            lblKelas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKelas.Location = new Point(121, 98);
            lblKelas.Name = "lblKelas";
            lblKelas.Size = new Size(14, 21);
            lblKelas.TabIndex = 4;
            lblKelas.Text = " ";
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 223);
            Controls.Add(lblKelas);
            Controls.Add(lblNama);
            Controls.Add(lblNIM);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnKosongkan);
            Controls.Add(btnTampilkan);
            Name = "Task";
            Text = "Tugas 3.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKosongkan;
        private Button btnTampilkan;
        private Label label1;
        private Label lblNIM;
        private Label label3;
        private Label lblNama;
        private Label label5;
        private Label lblKelas;
    }
}