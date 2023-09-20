namespace LatihanAutoLayout
{
    public partial class Latihan : Form
    {
        public Latihan()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = listPekerjaan.Text;

            textPesan1.Text = string.Format("Halo {0}", nama);
            textPesan2.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            textPesan3.Text = string.Format("Anda seorang {0}, hebat !!!", pekerjaan);
        }
    }
}