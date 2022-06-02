﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DonnaGabriela.Model;

namespace DonnaGabriela
{
    public partial class FormAdministrativo : Form
    {

        public FormAdministrativo()
        {
            InitializeComponent();
        }

        private void loadDataTable()
        {
            DatabaseUtils databaseUtils = new DatabaseUtils();

            VoluntariaModel model = new VoluntariaModel();
            SqlDataAdapter adapter = model.getVoluntariasByStatus("1");
            DataTable dt = new DataTable();

            try
            {
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
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!\n"+e.Message);
                lblError.Visible = true;
            }
        }

        private void FormAdministrativo_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void BtnCadastrarVoluntario_Click_1(object sender, EventArgs e)
        {
            FormEdicaoVoluntaria frm = new FormEdicaoVoluntaria();
            frm.Height = 600;
            frm.Width = 1024;
            frm.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form editVoluntaria = new FormEdicaoVoluntaria(getSelectedId());
            editVoluntaria.BringToFront();
            editVoluntaria.Show();
        }

        private void BtnDesativarCadastro_Click(object sender, EventArgs e)
        {
            //panelOverlay.BackColor = Color.FromArgb(128, Color.Black);
            //panelOverlay.Visible = true;
            panelModal.Visible = true;
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            //add logica de remover item da tabela
            VoluntariaModel model = new VoluntariaModel();
            model.deleteVoluntariaById(getSelectedId());
            panelModal.Visible = false;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private void btnDesativarCadastro_Click_1(object sender, EventArgs e)
        {
            panelModal.Visible = true;
        }

        private void btnModal_Click_1(object sender, EventArgs e)
        {
            panelModal.Visible = false;
        }

        private int getSelectedId()
        {
            return int.Parse(this.dataGridVoluntarias.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}