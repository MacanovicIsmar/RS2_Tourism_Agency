namespace RS2_TourismAgency.WinUI
{
    public partial class FrmKorisniciList : Form
    {

        public APIService KorisniciService { get; set; } = new APIService("Korisnici");

        public FrmKorisniciList()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var list = await KorisniciService.Get<dynamic>();
        }
    }
}