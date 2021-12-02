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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SehirlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sehirSorgulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            FormSehirSorgulama formSehirSorgulama = new FormSehirSorgulama();
            formSehirSorgulama.MdiParent = this;
            formSehirSorgulama.Show();
            //Form içinde form boyutlarında göstermesi için ayarlama yap.
            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
    }

