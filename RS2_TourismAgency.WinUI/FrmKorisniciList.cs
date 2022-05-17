using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using RS2_Tourism_Agency.Model.SearchObjects;

namespace RS2_TourismAgency.WinUI
{
    public partial class FrmKorisniciList : Form
    {

        public APIService KorisniciService { get; set; } = new APIService("Korisnik");

        public FrmKorisniciList()
        {
            InitializeComponent();
            DGW_Korisnici.AutoGenerateColumns = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var searchobject = new KorisniciSearchObject();
            searchobject.KorisnickoIme = TBUSERNAME.Text;
            searchobject.NameFTS = TBIME.Text;
            searchobject.IncludeRules = true;

            var list = await KorisniciService.Get<List<Korisnici>>(searchobject);
            DGW_Korisnici.DataSource = list;
        }

        private void DGW_Korisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Item = DGW_Korisnici.SelectedRows[0].DataBoundItem as Korisnici;

            FormKorisniciDetails Frm = new FormKorisniciDetails(Item);
            Frm.ShowDialog();














        }

        private void DGW_Korisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}