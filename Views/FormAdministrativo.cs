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
        //SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-29936OV\SQLEXPRESS;Initial Catalog=DonnaGabriela;User ID=adm;Password=123");
        string conexao = @"Data Source=.\SQLEXPRESS;Database=DonnaGabriela;Trusted_Connection=True";
        public FormAdministrativo()
        {
            InitializeComponent();

            /*  SqlCommand comando = new SqlCommand("Select ID_Voluntario AS ID, Nome_Voluntario AS Nome, Telefone_Voluntario AS Telefone From Voluntario", conexao);
              SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
              DataTable dataTable = new DataTable();
              dataAdapter.Fill(dataTable);
              dataGridVoluntarias.DataSource = dataTable;

              dataGridVoluntarias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              dataGridVoluntarias.MultiSelect = false;
            */
        }

        private void load_data()
        {
            /* dataGridVoluntarias.Columns.Clear();
            using (SqlConnection con1 = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand("Select ID_Voluntario AS ID, Nome_Voluntario AS Nome, Telefone_Voluntario AS Telefone From Voluntario", con1))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridVoluntarias.DataSource = dt;
                        }
                    }
                }
            }
            dataGridVoluntarias.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            dataGridVoluntarias.Columns.Insert(3, buttoncolumn);
            buttoncolumn.HeaderText = "Deletar linha";
            buttoncolumn.Width = 50;
            buttoncolumn.Text = "Deletar";
            buttoncolumn.UseColumnTextForButtonValue = true;*/
        }


        private void btnCadastrarVoluntario_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario frm = new FormCadastroUsuario();
            frm.Show();
        }

        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {

            /*   string selectd_id = dataGridVoluntarias.CurrentRow.Cells[0].Value.ToString();
               string selectd_nome = dataGridVoluntarias.CurrentRow.Cells[1].Value.ToString();
               string selectd_telefone = dataGridVoluntarias.CurrentRow.Cells[2].Value.ToString();

               string delete_row = "DELETE Voluntario WHERE ID_Voluntario = '"+ selectd_id + "'";
            */

            /*            if (MessageBox.Show("Tem Certeza?", "Deletar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            int Row = dataGridVoluntarias.CurrentCell.RowIndex;
                            SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-29936OV\SQLEXPRESS;Initial Catalog=DonnaGabriela;User ID=adm;Password=123");
                            SqlCommand comando = new SqlCommand("DELETE Voluntario WHERE ID_Voluntario = " + Convert.ToString(Row), conexao);
                            conexao.Open();
                            comando.ExecuteNonQuery();
                            conexao.Close();
                            dataGridVoluntarias.Rows.RemoveAt(Row);
                        }
            */
        }

        private void FormAdministrativo_Load(object sender, EventArgs e)
        {
            load_data();
        }

        /*private void dataGridVoluntarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 2)
            {
                 DataGridViewRow row = dataGridVoluntarias.Rows[e.ColumnIndex];
                if (MessageBox.Show(String.Format("Tem Certeza?", row.Cells["ID_Voluntario"].Value), "Deletar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(conexao))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE Voluntario WHERE ID_Voluntario=@ID_Voluntario", con1))
                        {
                            cmd.Parameters.AddWithValue("ID_Voluntario", row.Cells["ID_Voluntario"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }
                    load_data();
                }
            }
        }*/

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}