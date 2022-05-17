using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DonnaGabriela
{
    public partial class FormLogin : Form
    {

        SqlConnection Conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DonnaGabriela;Trusted_Connection=True");

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLoginSistema_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Open();

                string query_banco = "SELECT Senha_User, Email_User FROM Usuario WHERE Senha_User = '" + txtSenha.Text + "' AND Email_User = '" + txtEmail.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(query_banco, Conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                //REMOVER DEPOOOOOOOOOIS
                txtEmail.Text = "admin@admin.com";
                txtSenha.Text = "123";

                if (dt.Rows.Count == 1)
                {
                    FormPrincipal frm = new FormPrincipal();
                    this.Hide();
                    frm.Show();
                    Conexao.Close();
                } 
                else if (txtEmail.Text == "Insira seu e-mail")
                {
                    MessageBox.Show("Insira um e-mail para fazer login!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    Conexao.Close();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Insira um e-mail para fazer login!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexao.Close();
                    txtEmail.Focus();
                }
                else if (txtSenha.Text == "Insira sua senha")
                {
                    MessageBox.Show("Insira sua senha para fazer login!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexao.Close();
                    txtSenha.Focus();
                }  else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Insira sua senha para fazer login!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexao.Close();
                    txtSenha.Focus();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorreto!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexao.Close();
                    txtEmail.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Insira sua senha") {
                txtSenha.Text = "";
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Insira seu e-mail")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            txtSenha.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
