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
using DonnaGabriela.Model;

namespace DonnaGabriela
{
    public partial class FormAgendamentos : Form
    {
        public FormAgendamentos()
        {
            InitializeComponent();
        }

        private void FormAgendamentos_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void loadDataTable()
        {
            DatabaseUtils databaseUtils = new DatabaseUtils();

            AgendamentoModel model = new AgendamentoModel();
            SqlDataAdapter adapter = model.getAgendamentos();
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridAgendamentos.DataSource = dt;
                dataGridAgendamentos.Columns[0].Width = 215;
                dataGridAgendamentos.Columns[1].Width = 215;
                dataGridAgendamentos.Columns[2].Width = 215;
                dataGridAgendamentos.Columns[3].Width = 435;
                dataGridAgendamentos.Columns[4].Width = 435;
                dataGridAgendamentos.Columns[5].Width = 435;



                dataGridAgendamentos.MultiSelect = false;
                this.dataGridAgendamentos.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 205, 241);
                this.dataGridAgendamentos.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.White;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!\n" + e.Message);
            }
        }
    }
}
