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
                    Text=item.Isim,
                    Tag=item
                };

                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);
                listView1.Items.Add(deger);
            }

            groupBoxSehir.Visible = false;
            // "Detay göster" şeklinde sağ tık menüsüne ihtiyacımız var.
            // Bu kontrol ToolBox'ta ContexMenu olarak var. Istersek Designer ekranında form üzerine çekip yerleştirebiliriz.
            // Fakat biz bunu Code ekranında yapacağız.

            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            // ComboBox'ta hangi il varsa onun bilgilerini listView'de gösterelim.


            /* Linq ile şart yazdık:
             * Where ---> koşula göre bilgileri getirir.
             * FirstorDefault ---> Where'den dönen liste elemanlarından sadece birini alır. */
            Sehirler SecilenSehir = comboBoxSehirSecimi.SelectedItem as Sehirler;
           SehirVeIlceBilgileri secilenSehirBilgisi = SehirVeIlceServisim.BilgileriGetir().Where(x => x.PlakaKodu == SecilenSehir.PlakaKodu).FirstOrDefault();

            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();

            deger.Text = secilenSehirBilgisi.Isim;
            deger.Tag = secilenSehirBilgisi;

            deger.SubItems.Add(secilenSehirBilgisi.Tel);
            deger.SubItems.Add(secilenSehirBilgisi.Faks);
            deger.SubItems.Add(secilenSehirBilgisi.Mail);
            deger.SubItems.Add(secilenSehirBilgisi.Web);
            listView1.Items.Add(deger);
        }

        private void detaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxSehir.Visible = true;

            SehirVeIlceBilgileri secilenSehir = (SehirVeIlceBilgileri)listView1.FocusedItem.Tag;
            richTextBoxSehir.Text = secilenSehir.Bilgi;


        }
    }
}
