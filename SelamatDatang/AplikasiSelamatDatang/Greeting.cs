namespace AplikasiSelamatDatang
{
    public partial class Greeting : Form
    {
        public Greeting()
        {
            InitializeComponent();
        }

        private void btnKeterangan1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Selamat Datang di Pemrograman C#";
        }

        private void btnKeterangan2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Begitu mudahnya membuat aplikasi berbasis windows";
        }
    }
}