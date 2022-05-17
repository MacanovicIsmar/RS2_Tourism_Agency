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
    public partial class FrmLogIn : Form
    {

        private readonly APIService Service 
            = new APIService("Korisnik");

        public FrmLogIn()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private async Task BT_LogIn_ClickAsync(object sender, EventArgs e)
        //{
            




        //}

        private async void BT_LogIn_Click(object sender, EventArgs e)
        {
            APIService.Username = TB_UserName.Text;
            APIService.Password = TB_PassWord.Text;



            try
            {
                var result = await Service.Get<dynamic>();

                MDIMain frm = new MDIMain();
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Wrong Username or Password");



            }
        }
    }
}
