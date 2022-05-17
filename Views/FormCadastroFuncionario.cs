using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonnaGabriela.Views
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.AutoScroll = false;
            panelContainer.VerticalScroll.Enabled = true;
            panelContainer.VerticalScroll.Visible = true;

            panelContainer.AutoScroll = true;
        }

        private void TxtNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
