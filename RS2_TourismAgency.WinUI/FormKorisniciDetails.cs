using RS2_Tourism_Agency.Model;
using RS2_Tourism_Agency.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS2_TourismAgency.WinUI
{
    public partial class FormKorisniciDetails : Form
    {

        public APIService KorisniciService { get; set; } = new APIService("Korisnik");
        public APIService RoleService { get; set; } = new APIService("Uloge");

        private Korisnici Model = null;

        public FormKorisniciDetails(Korisnici Model_ =null)
        {

            InitializeComponent();
            Model = Model_;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BT_Sacuvaj_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {

                var rolelist = CHECKLISTBOX_Uloge.CheckedItems.Cast<Uloge>().ToList();
                var roleidlist = rolelist.Select(X => X.Id).ToList();
                //var user;

                if (Model == null)
                {

                    KorisniciInsertRequest InsertRequest = new KorisniciInsertRequest()
                    {
                        Ime = TB_Ime.Text,
                        Prezime = TB_Prezime.Text,
                        Email = TB_Mail.Text,
                        UserName = TB_USERNAME.Text,
                        Password = TB_PASSWORD.Text,
                        PasswordConfirm = TB_CONFIRMATION.Text,
                        Status = CB_Status.Checked,
                        UlogeIdList = roleidlist

                    };
                    var user = await KorisniciService.Post<RS2_Tourism_Agency.Model.Korisnici>(InsertRequest);
                }
                else
                {
                    KorisnikUpdateRequest UpdateRequest = new KorisnikUpdateRequest()
                    {
                        Ime = TB_Ime.Text,
                        Prezime = TB_Prezime.Text,
                        Email = TB_Mail.Text,

                        Password = TB_PASSWORD.Text,
                        PasswordConfirm = TB_CONFIRMATION.Text,
                        Status = CB_Status.Checked,
                        UlogeIdList = roleidlist

                    };

                    Model = await KorisniciService.Put<RS2_Tourism_Agency.Model.Korisnici>(Model.Id, UpdateRequest);

                }




                MessageBox.Show("UserAdded");

            }

        }

        private async void FormKorisniciDetails_Load(object sender, EventArgs e)
        {

            await LoadRoles();

            if (Model != null)
            {
                TB_Ime.Text = Model.Ime;
                TB_Prezime.Text = Model.Prezime;            
                TB_Mail.Text = Model.Email;
                //TB_PASSWORD.Text = Model.Password;
                //TB_CONFIRMATION.Text = Model.Password;
                CB_Status.Checked = Model.Status.GetValueOrDefault(false);




            }


        }

        private async Task LoadRoles()
        {

            var roles = await RoleService.Get<List<Uloge>>();
            CHECKLISTBOX_Uloge.DataSource = roles;
            CHECKLISTBOX_Uloge.DisplayMember = "Naziv";



        }

        private void TB_Ime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_Ime.Text))
            {
                e.Cancel = true;
                TB_Ime.Focus();
                ErrorProvider.SetError(TB_Ime, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                ErrorProvider.SetError(TB_Ime, "");
            }
        }

        
    }
}
