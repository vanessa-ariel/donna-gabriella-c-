using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonnaGabriela
{
    public partial class FormConfiguracoes : Form
    {

        public FormConfiguracoes()
        {
            InitializeComponent();
        }
        ScrollBar vScrollBar1 = new VScrollBar();

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            panelContainer.AutoScroll = false;
            panelContainer.VerticalScroll.Enabled = true;
            panelContainer.VerticalScroll.Visible = true;
            panelContainer.AutoScroll = true;
            panelContainer.AutoScrollMinSize = new System.Drawing.Size(250, 1900);
            panelContainer.Width = 1024;
        }

        private void PnlInner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
