namespace AplikasiSelamatDatang
{
    partial class Greeting
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
            lblKeterangan = new Label();
            btnKeterangan1 = new Button();
            btnKeterangan2 = new Button();
            SuspendLayout();
            // 
            // lblKeterangan
            // 
            lblKeterangan.AutoSize = true;
            lblKeterangan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKeterangan.ForeColor = Color.Red;
            lblKeterangan.Location = new Point(12, 42);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(287, 21);
            lblKeterangan.TabIndex = 0;
            lblKeterangan.Text = "Selamat Datang di Pemrograman C#";
            lblKeterangan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKeterangan1
            // 
            btnKeterangan1.Location = new Point(114, 88);
            btnKeterangan1.Name = "btnKeterangan1";
            btnKeterangan1.Size = new Size(111, 28);
            btnKeterangan1.TabIndex = 1;
            btnKeterangan1.Text = "Keterangan 1";
            btnKeterangan1.UseVisualStyleBackColor = true;
            btnKeterangan1.Click += btnKeterangan1_Click;
            // 
            // btnKeterangan2
            // 
            btnKeterangan2.Location = new Point(231, 88);
            btnKeterangan2.Name = "btnKeterangan2";
            btnKeterangan2.Size = new Size(111, 28);
            btnKeterangan2.TabIndex = 1;
            btnKeterangan2.Text = "Keterangan 2";
            btnKeterangan2.UseVisualStyleBackColor = true;
            btnKeterangan2.Click += btnKeterangan2_Click;
            // 
            // Greeting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 159);
            Controls.Add(btnKeterangan2);
            Controls.Add(btnKeterangan1);
            Controls.Add(lblKeterangan);
            Name = "Greeting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Selamat Datang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKeterangan;
        private Button btnKeterangan1;
        private Button btnKeterangan2;
    }
}