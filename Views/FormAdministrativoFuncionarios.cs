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

namespace DonnaGabriela.Views
{
    public partial class FormAdministrativoFuncionarios : Form
    {
        public FormAdministrativoFuncionarios()
        {
            InitializeComponent();
        }

        private void loadDataTable()
        {
            DatabaseUtils databaseUtils = new DatabaseUtils();

            VoluntariaModel model = new VoluntariaModel();
            SqlDataAdapter adapter = model.getVoluntariasByStatus("ativo");
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                tableHeader.Visible = true;
                btnEditar.Visible = true;
                btnDesativarCadastro.Visible = true;
                dataGridFuncionarios.DataSource = dt;
                dataGridFuncionarios.Columns[0].Width = 100;
                dataGridFuncionarios.Columns[1].Width = 500;

                dataGridFuncionarios.MultiSelect = false;
                this.dataGridFuncionarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 205, 241);
                this.dataGridFuncionarios.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.White;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!\n" + e.Message);
                lblError.Visible = true;
            }
        }

    }
}
