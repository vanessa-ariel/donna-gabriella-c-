using System;
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

            loadContentVoluntaria();
            loadContentUsuaria();
        }

        private void loadContentVoluntaria()
        {
            if (voluntarias.Count() == 0)
            {
                panel3.Visible = false;
                pnInfo.Visible = false;
                panelEmpty.Visible = true;
                return;
            }
            setNextVoluntaria();
        }
        private void loadContentUsuaria()
        {
            if (usuarias.Count() == 0)
            {
                panel4.Visible = false;
                panel5.Visible = false;
                panelEmptyUsuaria.Visible = true;
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
            panelEmpty.Visible = false;
            if (voluntarias.Count() == 0)
            {
                panelEmpty.Visible = true;
                return;
            }

            Voluntaria current = voluntarias.First();
            string id = current.ID_Voluntario.ToString();

            string target = "http://localhost:8080/donnagabriela.com.br/aprovacao-voluntaria?id=" + id;
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
            showEmptyMessageVoluntarias();
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
                return;
            }
            Usuaria current = usuarias.First();
            txtNomeUsuaria.Text = current.Nome_User;
            txtDataUsuaria.Text = current.Data_Cadastro;
            txtEmailUsuaria.Text = current.Email_User;
            txtTelefoneUsuaria.Text = current.Telefone_User;
        }

        private void btnAprovarUsuaria_Click(object sender, EventArgs e)
        {
            Console.WriteLine("APROVE++ ");
            updateUsuariaStatus("1");
            panelEmptyUsuaria.Visible = false;
            if (usuarias.Count() == 0)
            {
                panelEmptyUsuaria.Visible = true;
                return;
            }

            Usuaria current = usuarias.First();
            String id = current.ID_User.ToString();
            string target = "http://localhost:8080/donnagabriela.com.br/aprovacao-usuario?id=" + id;
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
            showEmptyMessageUsuarias();
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

        private void showEmptyMessageVoluntarias()
        {
            panelEmpty.Visible = false;
            if (voluntarias.Count() == 0)
            {
                panelEmpty.Visible = true;
                return;
            }
        }

        private void showEmptyMessageUsuarias()
        {
            panelEmptyUsuaria.Visible = false;
            if (usuarias.Count() == 0)
            {
                panelEmptyUsuaria.Visible = true;
                return;
            }
        }
    }
}
