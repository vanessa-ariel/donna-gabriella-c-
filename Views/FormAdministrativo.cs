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

namespace DonnaGabriela
{
    public partial class FormAdministrativo : Form
    {

        public FormAdministrativo()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();

        public void PullData()
        {
            string connString = @"Data Source=.\SQLEXPRESS;Database=DonnaGabriela;Trusted_Connection=True";
            string query = "SELECT ID_Voluntario, Nome_Voluntario, Telefone_Voluntario FROM Voluntario WHERE Status_Conta = 'ativo'";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try{
                conn.Open();
                adapter.Fill(dt);
                tableHeader.Visible = true;
                btnEditar.Visible = true;
                btnDesativarCadastro.Visible = true;
                dataGridVoluntarias.DataSource = dt;
                dataGridVoluntarias.Columns[0].Width = 100;
                dataGridVoluntarias.Columns[1].Width = 500;

                dataGridVoluntarias.MultiSelect = false;
                this.dataGridVoluntarias.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 205, 241);
                this.dataGridVoluntarias.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.White;
                conn.Close();
            }
                catch (Exception){
            MessageBox.Show("Não foi possível conectar ao banco de dados ! ");
                lblError.Visible = true;
            }
        }

 

        private void load_data()
        {
            PullData();
        }


        private void FormAdministrativo_Load(object sender, EventArgs e)
        {
            load_data();
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCadastrarVoluntario_Click_1(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            frm.Height = 600;
            frm.Width = 1024;
            frm.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDesativarCadastro_Click(object sender, EventArgs e)
        {
            //panelOverlay.BackColor = Color.FromArgb(128, Color.Black);
            //panelOverlay.Visible = true;
            panelModal.Visible = true;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            //add logica de remover item da tabela
            panelModal.Visible = false;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private void IconeFechar_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }
    }
}