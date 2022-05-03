using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using RS2_Tourism_Agency.Model;

namespace RS2_TourismAgency.WinUI
{
    public partial class FrmPutovanjaList : Form
    {
        public APIService ProductService { get; set;}= new APIService("Putovanje");

        public FrmPutovanjaList()
        {
            InitializeComponent();
        }

        private async void BtnShow_Click(object sender, EventArgs e)
        {
            var list = await ProductService.Get<List<Putovanje>>();

            var entity = await ProductService.GetById<Putovanje>(1011);

            entity.Naziv = "Updated product WinUI";

            var update = await ProductService.Put<Putovanje>(entity.Id, entity);
        }
    }
}
