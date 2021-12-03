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
    public partial class FormSehrinIlceleri : Form
    {
        public FormSehrinIlceleri()
        {
            InitializeComponent();
        }

        SehirlerServis SehirServisim = new SehirlerServis();
        SehirlerVeIlcelerServis IlceServis = new SehirlerVeIlcelerServis();

        private void FormSehrinIlceleri_Load(object sender, EventArgs e)
        {
            comboBoxSehirler.DataSource = SehirServisim.SehirleriGetir();
            comboBoxSehirler.DisplayMember = "SehirAdi";
            comboBoxSehirler.ValueMember = "PlakaKodu";
            


        }

        private void comboBoxSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehirler secilenSehir = comboBoxSehirler.SelectedItem as Sehirler;

            // BLL'in bilgileri getirmesine ihtiyacımız var.
            // BLL'de öyle bir metot olmalı ki, il ismini paramatere olarak verince bize ilçeye dair bilgileri versin.
            List<SehirVeIlceBilgileri> sehreAitIlcelerListem = IlceServis.SehirAdinaGoreIlceleriGetir(secilenSehir.SehirAdi);

            listView1.Items.Clear();

            foreach (var item in sehreAitIlcelerListem)
            {
                ListViewItem lwi = new ListViewItem();
                lwi.Text = item.Isim;
                lwi.Tag = item;
                lwi.SubItems.Add(item.Tel);
                lwi.SubItems.Add(item.Mail);
                listView1.Items.Add(lwi);
            }



        }
    }
}
