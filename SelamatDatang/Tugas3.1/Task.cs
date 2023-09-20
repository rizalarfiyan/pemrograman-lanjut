namespace Tugas3._1
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "22.11.5227";
            lblNama.Text = "Muhamad Rizal Arfiyan";
            lblKelas.Text = "IF11";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNIM.Text = " ";
            lblNama.Text = " ";
            lblKelas.Text = " ";
        }
    }
}