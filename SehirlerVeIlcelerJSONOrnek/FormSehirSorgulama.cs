using SehirlerVeIlcelerJSON_BLL;
using SehirlerVeIlcelerJSON_ENTITYMODELS.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirlerVeIlcelerJSONOrnek
{
    public partial class FormSehirSorgulama : Form
    {
        public FormSehirSorgulama()
        {
            InitializeComponent();
        }

        SehirlerServis SehirServisim = new SehirlerServis();
        SehirlerVeIlcelerServis SehirVeIlceServisim = new SehirlerVeIlcelerServis();

        private void FormSehirSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxSehirSecimi.DataSource = SehirServisim.SehirleriGetir() ;
            comboBoxSehirSecimi.DisplayMember = "SehirAdi";
            comboBoxSehirSecimi.ValueMember = "PlakaKodu";

            List<SehirVeIlceBilgileri> SehireAitBilgilerListesi = SehirVeIlceServisim.BilgileriGetir();

            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text=item.Isım,
                    Tag=item
                };

                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);
                listView1.Items.Add(deger);
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {

        }
    }
}
