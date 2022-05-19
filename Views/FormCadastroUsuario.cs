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
    public partial class FormCadastroUsuario : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source=LAPTOP-BMV2PG56;Initial Catalog=DonnaGabriela;User ID=sa; Password=123");

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarVol_Click(object sender, EventArgs e)
        {
            try
            {
                // Comandos SQL
                SqlCommand comando = new SqlCommand("INSERT INTO Voluntario(Nome_Servico, Nome_Voluntario, Telefone_Voluntario, Email_Voluntario, Cep_Voluntario, Endereco_Voluntario, Numero_Voluntario, Bairro_Voluntario, Cidade_Voluntario, Complemento_Voluntario, Senha_Voluntario) VALUES (@Nome_Servico, @Nome_Voluntario, @Telefone_Voluntario, @Email_Voluntario, @Cep_Voluntario, @Endereco_Voluntario, @Numero_Voluntario, @Bairro_Voluntario, @Cidade_Voluntario, @Complemento_Voluntario, @Senha_Voluntario)", conexao);
                comando.Parameters.Add("@Nome_Servico", SqlDbType.VarChar).Value = cmbProfissoes.Text;
                comando.Parameters.Add("@Nome_Voluntario", SqlDbType.VarChar).Value = txtNomeVol.Text;
                comando.Parameters.Add("@Telefone_Voluntario", SqlDbType.VarChar).Value = txtTelefoneVol.Text;
                comando.Parameters.Add("@Email_Voluntario", SqlDbType.VarChar).Value = txtEmailVol.Text;
                comando.Parameters.Add("@Cep_Voluntario", SqlDbType.VarChar).Value = txtcepVol.Text;
                comando.Parameters.Add("@Endereco_Voluntario", SqlDbType.VarChar).Value = txtRuaVol.Text;
                comando.Parameters.Add("@Numero_Voluntario", SqlDbType.VarChar).Value = txtNumeroVol.Text;
                comando.Parameters.Add("@Bairro_Voluntario", SqlDbType.VarChar).Value = txtBairroVol.Text;
                comando.Parameters.Add("@Cidade_Voluntario", SqlDbType.VarChar).Value = txtCidadeVol.Text;
                comando.Parameters.Add("@Complemento_Voluntario", SqlDbType.VarChar).Value = txtComplementoVol.Text;
                comando.Parameters.Add("@Senha_Voluntario", SqlDbType.VarChar).Value = txtSenhaVol.Text;
               
                if (txtNomeVol.Text == "Insira seu nome")
                {
                    MessageBox.Show("Insira um nome para para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeVol.Focus();
                    conexao.Close();
                }
                else if (txtNomeVol.Text == "Insira seu e-mail")
                {
                    MessageBox.Show("Insira um e-mail para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailVol.Focus();
                    conexao.Close();
                } else if (txtEmailVol.Text == "")
                {
                    MessageBox.Show("Insira um e-mail para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmailVol.Focus();
                    conexao.Close();
                }
                else if (txtTelefoneVol.Text == "Insira seu telefone")
                {
                    MessageBox.Show("Insira um telefone para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefoneVol.Focus();
                    conexao.Close();
                }
                else if (txtTelefoneVol.Text == "")
                {
                    MessageBox.Show("Insira um telefone para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefoneVol.Focus();
                    conexao.Close();
                }
                else if (txtcepVol.Text == "Insira o cep")
                {
                    MessageBox.Show("Insira um cep para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcepVol.Focus();
                    conexao.Close();
                }
                else if (txtcepVol.Text == "")
                {
                    MessageBox.Show("Insira um cep para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcepVol.Focus();
                    conexao.Close();
                }
                else if (txtRuaVol.Text == "Insira o nome da rua")
                {
                    MessageBox.Show("Insira a rua para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRuaVol.Focus();
                    conexao.Close();
                }
                else if (txtRuaVol.Text == "")
                {
                    MessageBox.Show("Insira a rua para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRuaVol.Focus();
                    conexao.Close();
                }
                else if (txtBairroVol.Text == "Insira o bairro")
                {
                    MessageBox.Show("Insira o bairro para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBairroVol.Focus();
                    conexao.Close();
                }
                else if (txtBairroVol.Text == "")
                {
                    MessageBox.Show("Insira o bairro para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBairroVol.Focus();
                    conexao.Close();
                }
                else if (txtCidadeVol.Text == "Insira a cidade")
                {
                    MessageBox.Show("Insira a cidade para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidadeVol.Focus();
                    conexao.Close();
                }
                else if (txtCidadeVol.Text == "")
                {
                    MessageBox.Show("Insira a cidade para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidadeVol.Focus();
                    conexao.Close();
                }
                else if (txtNumeroVol.Text == "Insira o número")
                {
                    MessageBox.Show("Insira o numero para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeroVol.Focus();
                    conexao.Close();
                }
                else if (txtNumeroVol.Text == "")
                {
                    MessageBox.Show("Insira o numero para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeroVol.Focus();
                    conexao.Close();
                }
                else if (txtComplementoVol.Text == "Insira seu complemento")
                {
                    MessageBox.Show("Insira o complemento para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplementoVol.Focus();
                    conexao.Close();
                }
                else if (txtComplementoVol.Text == "")
                {
                    MessageBox.Show("Insira o complemento para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplementoVol.Focus();
                    conexao.Close();
                }
                else if (txtSenhaVol.Text == "Crie uma senha")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaVol.Focus();
                    conexao.Close();
                }
                else if (txtSenhaVol.Text == "")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenhaVol.Focus();
                    conexao.Close();
                }
                else if (txtConfirmacaoSenhaVol.Text == "Confirmação de senha")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenhaVol.Focus();
                    conexao.Close();
                }
                else if (txtConfirmacaoSenhaVol.Text == "")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenhaVol.Focus();
                    conexao.Close();
                }
                else if (txtSenhaVol.Text != txtConfirmacaoSenhaVol.Text)
                {
                    MessageBox.Show("Insira as senhas iguais para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenhaVol.Focus();
                    conexao.Close();
                }
                else
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

