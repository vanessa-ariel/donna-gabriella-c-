using DonnaGabriela.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonnaGabriela.Fonts;

namespace DonnaGabriela.Views
{
    public partial class FormAdministrativoFuncionarios : Form
    {
        public FormAdministrativoFuncionarios()
        {
            InitializeComponent();
        }

        public void loadDataTable()
        {
            DatabaseUtils databaseUtils = new DatabaseUtils();

            FuncionarioModel model = new FuncionarioModel();
            SqlDataAdapter adapter = model.getFuncionariosByStatus("1");
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                tableHeader.Visible = true;
                btnEditar.Visible = true;
                btnDesativarCadastro.Visible = true;
                dataGridFuncionarios.DataSource = dt;
                dataGridFuncionarios.Columns[0].Width = 250;
                dataGridFuncionarios.Columns[1].Width = 100;
                dataGridFuncionarios.Columns[2].Width = 200;
                dataGridFuncionarios.Columns[3].Width = 260;

                dataGridFuncionarios.MultiSelect = false;
                this.dataGridFuncionarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 205, 241);
                this.dataGridFuncionarios.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.White;
                if (dataGridFuncionarios.Rows.Count == 0)
                {
                    tableHeader.Visible = false;
                    lblError.Text = "Nenhum funcionário cadastrado.";
                    lblError.Visible = true;
                    btnDesativarCadastro.Visible = false;
                    btnEditar.Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!\n" + e.Message);
                lblError.Visible = true;
            }
        }


        private void FormAdministrativoFuncionarios_Load(object sender, EventArgs e)
        {
            //GetFont getFont = new GetFont();
            //getFont.CustomFonts(this);
            loadDataTable();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form editFuncionarios = new FormNovoCadastroFuncionario(getSelectedId());
            editFuncionarios.Owner = this;
            editFuncionarios.BringToFront();
            editFuncionarios.Show();
        }
        private int getSelectedId()
        {
            return int.Parse(this.dataGridFuncionarios.SelectedRows[0].Cells[1].Value.ToString());
        }

        private void iconButtonNovo_Click(object sender, EventArgs e)
        {
            Form addFuncionarios = new FormNovoCadastroFuncionario();
            addFuncionarios.Owner = this;
            addFuncionarios.BringToFront();
            addFuncionarios.Show();
        }

        private void btnDesativarCadastro_Click(object sender, EventArgs e)
        {
            panelModal.Visible = true;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            FuncionarioModel model = new FuncionarioModel();
            model.deleteFuncionarioById(getSelectedId());
            loadDataTable();
            panelModal.Visible = false;

        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
