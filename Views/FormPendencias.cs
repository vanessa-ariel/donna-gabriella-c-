﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonnaGabriela.Model;

namespace DonnaGabriela
{
    public partial class FormPendencias : Form
    {
        List<Voluntaria> voluntarias;
        List<Usuaria> usuarias;

        public FormPendencias()
        {
            InitializeComponent();
        }

        private void FormPendencias_Load(object sender, EventArgs e)
        {
            VoluntariaModel model = new VoluntariaModel();
            voluntarias = model.getVoluntariasPendentes();

            UsuariaModel modelUser = new UsuariaModel();
            usuarias = modelUser.getUsuariasPendentes();

            Console.WriteLine("COUNT++ " + voluntarias.Count());

            updatePendenciasLeft();
            updatePendenciasLeftUsuaria();

            if (voluntarias.Count() == 0)
            {
                return;
            }
            setNextVoluntaria();

            if (usuarias.Count() == 0)
            {
                return;
            }
            setNextUsuaria();
        }


        private void updatePendenciasLeft()
        {
            lblQtdPendencias.Text = voluntarias.Count().ToString();
        }
        private void btnAprovar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("APROVE++ ");

            updateVoluntariaStatus("1");
            string id = txtIdVol.Text;
            string target = "http://localhost:8080/donnagabriela.com.br/usuario?id=" + id;
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            };
        }

        private void btnReprovar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("REJECT++ ");

            updateVoluntariaStatus("2");
        }

        private void setNextVoluntaria()
        {
            if(voluntarias.Count() == 0)
            {
                txtNome.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                return;
            }
            Voluntaria current = voluntarias.First();
            txtNome.Text = current.Nome_Voluntario;
            textBox1.Text = current.Data_Cadastro;
            textBox2.Text = current.Email_Voluntario;
            textBox3.Text = current.Telefone_Voluntario;
            textBox4.Text = current.Nome_Servico;
            txtIdVol.Text = current.ID_Voluntario.ToString();
        }

        private void updateVoluntariaStatus(String status)
        {
            Console.WriteLine("COUNT 2++ " + voluntarias.Count());

            if (voluntarias.Count() == 0)
            {
                return;
            }

            Voluntaria current = voluntarias.First();
            current.Status_Conta = status;
//            current.ID_Voluntario =

            Console.WriteLine("ID++ " + current.ID_Voluntario);
            Console.WriteLine("STATUS++ " + current.Status_Conta);
            Console.WriteLine("NAME++ " + current.Nome_Voluntario);

            VoluntariaModel model = new VoluntariaModel();
            model.editVoluntaria(current);

            voluntarias.Remove(voluntarias.First());

            setNextVoluntaria();
            updatePendenciasLeft();
        }


        private void updatePendenciasLeftUsuaria()
        {
            lblQtdPendenciasUsuaria.Text = usuarias.Count().ToString();
        }

        private void setNextUsuaria()
        {
            if (usuarias.Count() == 0)
            {
                txtNomeUsuaria.Text = "";
                txtDataUsuaria.Text = "";
                txtEmailUsuaria.Text = "";
                txtTelefoneUsuaria.Text = "";
                txtIdUsuaria.Text = "";
                return;
            }
            Usuaria current = usuarias.First();
            txtNomeUsuaria.Text = current.Nome_User;
            txtDataUsuaria.Text = current.Data_Cadastro;
            txtEmailUsuaria.Text = current.Email_User;
            txtTelefoneUsuaria.Text = current.Telefone_User;
            txtIdUsuaria.Text = current.ID_User.ToString();

        }

        private void btnAprovarUsuaria_Click(object sender, EventArgs e)
        {
            Console.WriteLine("APROVE++ ");
            updateUsuariaStatus("1");

            string id = txtIdUsuaria.Text;
            string target = "http://localhost:8080/donnagabriela.com.br/usuario?id=" + id;
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch(System.ComponentModel.Win32Exception noBrowser){
                MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            };
        }

        private void btnReprovarUsuaria_Click(object sender, EventArgs e)
        {
            Console.WriteLine("REJECT++ ");

            updateUsuariaStatus("2");
        }

        private void updateUsuariaStatus(String status)
        {
            Console.WriteLine("COUNT 2++ " + usuarias.Count());

            if (usuarias.Count() == 0)
            {
                return;
            }

            Usuaria current = usuarias.First();
            current.Status_Conta = status;

            Console.WriteLine("ID++ " + current.ID_User);
            Console.WriteLine("STATUS++ " + current.Status_Conta);
            Console.WriteLine("NAME++ " + current.Nome_User);

            UsuariaModel model = new UsuariaModel();
            model.editUsuaria(current);

            usuarias.Remove(usuarias.First());

            setNextUsuaria();
            updatePendenciasLeftUsuaria();
        }
    }
}
