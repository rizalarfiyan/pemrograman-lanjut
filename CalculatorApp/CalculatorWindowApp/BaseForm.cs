using System;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowApp
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            // casting
            var a = int.Parse(inputNilaiA.Text);
            // casting
            var b = Convert.ToInt32(inputNilaiB.Text);

            // kosongkan isi listbox
            listHasil.Items.Clear();

            var calc = new Calculator();

            listHasil.Items.Add(string.Format("Hasil pengurangan: {0} - {1} = {2}", a, b, calc.Pengurangan(a, b)));
            listHasil.Items.Add(string.Format("Hasil penambahan: {0} + {1} = {2}", a, b, calc.Penambahan(a, b)));
            listHasil.Items.Add(string.Format("Hasil perkalian: {0} * {1} = {2}", a, b, calc.Perkalian(a, b)));
            listHasil.Items.Add(string.Format("Hasil pembagian: {0} / {1} = {2}", a, b, calc.Pembagian(a, b)));
            listHasil.Items.Add(string.Format("Hasil pangkat: {0} ^ {1} = {2}", a, b, calc.Pangkat(a, b)));
            listHasil.Items.Add(string.Format("Hasil modulo: {0} % {1} = {2}", a, b, calc.Modulo(a, b)));
        }
    }
}
