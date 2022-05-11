using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.SearchObjects;

namespace RS2_TourismAgency.WinUI
{
    public partial class FrmKorisniciList : Form
    {

        public APIService KorisniciService { get; set; } = new APIService("Korisnik");

        public FrmKorisniciList()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var searchobject = new KorisniciSearchObject();
            searchobject.KorisnickoIme = TBUSERNAME.Text;
            searchobject.NameFTS = TBIME.Text;

            var list = await KorisniciService.Get<List<Korisnici>>(searchobject);
            DGW_Korisnici.DataSource = list;
        }
    }
}