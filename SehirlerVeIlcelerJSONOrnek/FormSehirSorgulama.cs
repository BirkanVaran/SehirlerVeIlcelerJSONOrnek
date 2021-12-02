using SehirlerVeIlcelerJSON_BLL;
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

        private void FormSehirSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxSehirSecimi.DataSource = SehirServisim.SehirleriGetir() ;
            comboBoxSehirSecimi.DisplayMember = "Şehir seçiniz...";
        }
    }
}
