using CalculatorMachine;
using System;
using System.Windows.Forms;

namespace CalculatorWindowApp
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }
        private void buttonHitung_Click(object sender, EventArgs e)
        {
            string selected = this.operasi.GetItemText(this.operasi.SelectedItem);

            var nilaiA = Convert.ToInt32(inputNilaiA.Text);
            var nilaiB = Convert.ToInt32(inputNilaiB.Text);
            var calc = new Calculator();

            switch (selected)
            {
                case "Tambah":
                    hasil.Text = calc.Penambahan(nilaiA, nilaiB).ToString();
                    return;
                case "Kurang":
                    hasil.Text = calc.Pengurangan(nilaiA, nilaiB).ToString();
                    return;
                case "Kali":
                    hasil.Text = calc.Perkalian(nilaiA, nilaiB).ToString();
                    return;
                case "Bagi":
                    hasil.Text = calc.Pembagian(nilaiA, nilaiB).ToString();
                    return;
                case "Pangkat":
                    hasil.Text = calc.Pangkat(nilaiA, nilaiB).ToString();
                    return;
                case "Modulo":
                    hasil.Text = calc.Modulo(nilaiA, nilaiB).ToString();
                    return;
                default:
                    return;
            }
        }
    }
}
