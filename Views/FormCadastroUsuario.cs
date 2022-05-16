﻿using System;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comandos SQL
                SqlCommand comando = new SqlCommand("INSERT INTO Voluntario(Nome_Servico, Nome_Voluntario, Telefone_Voluntario, Email_Voluntario, Cep_Voluntario, Endereco_Voluntario, Numero_Voluntario, Bairro_Voluntario, Cidade_Voluntario, Complemento_Voluntario, Senha_Voluntario) VALUES (@Nome_Servico, @Nome_Voluntario, @Telefone_Voluntario, @Email_Voluntario, @Cep_Voluntario, @Endereco_Voluntario, @Numero_Voluntario, @Bairro_Voluntario, @Cidade_Voluntario, @Complemento_Voluntario, @Senha_Voluntario)", conexao);
                comando.Parameters.Add("@Nome_Servico", SqlDbType.VarChar).Value = cmbProfissoes.Text;
                comando.Parameters.Add("@Nome_Voluntario", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@Telefone_Voluntario", SqlDbType.VarChar).Value = txtTelefone.Text;
                comando.Parameters.Add("@Email_Voluntario", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("@Cep_Voluntario", SqlDbType.VarChar).Value = txtcep.Text;
                comando.Parameters.Add("@Endereco_Voluntario", SqlDbType.VarChar).Value = txtRua.Text;
                comando.Parameters.Add("@Numero_Voluntario", SqlDbType.VarChar).Value = txtNumero.Text;
                comando.Parameters.Add("@Bairro_Voluntario", SqlDbType.VarChar).Value = txtBairro.Text;
                comando.Parameters.Add("@Cidade_Voluntario", SqlDbType.VarChar).Value = txtCidade.Text;
                comando.Parameters.Add("@Complemento_Voluntario", SqlDbType.VarChar).Value = txtComplemento.Text;
                comando.Parameters.Add("@Senha_Voluntario", SqlDbType.VarChar).Value = txtSenha.Text;
               
                if (txtNome.Text == "Insira seu nome")
                {
                    MessageBox.Show("Insira um nome para para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Focus();
                    conexao.Close();
                }
                else if (txtNome.Text == "Insira seu e-mail")
                {
                    MessageBox.Show("Insira um e-mail para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    conexao.Close();
                } else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Insira um e-mail para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                    conexao.Close();
                }
                else if (txtTelefone.Text == "Insira seu telefone")
                {
                    MessageBox.Show("Insira um telefone para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefone.Focus();
                    conexao.Close();
                }
                else if (txtTelefone.Text == "")
                {
                    MessageBox.Show("Insira um telefone para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefone.Focus();
                    conexao.Close();
                }
                else if (txtcep.Text == "Insira o cep")
                {
                    MessageBox.Show("Insira um cep para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcep.Focus();
                    conexao.Close();
                }
                else if (txtcep.Text == "")
                {
                    MessageBox.Show("Insira um cep para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcep.Focus();
                    conexao.Close();
                }
                else if (txtRua.Text == "Insira o nome da rua")
                {
                    MessageBox.Show("Insira a rua para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRua.Focus();
                    conexao.Close();
                }
                else if (txtRua.Text == "")
                {
                    MessageBox.Show("Insira a rua para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRua.Focus();
                    conexao.Close();
                }
                else if (txtBairro.Text == "Insira o bairro")
                {
                    MessageBox.Show("Insira o bairro para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBairro.Focus();
                    conexao.Close();
                }
                else if (txtBairro.Text == "")
                {
                    MessageBox.Show("Insira o bairro para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBairro.Focus();
                    conexao.Close();
                }
                else if (txtCidade.Text == "Insira a cidade")
                {
                    MessageBox.Show("Insira a cidade para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidade.Focus();
                    conexao.Close();
                }
                else if (txtCidade.Text == "")
                {
                    MessageBox.Show("Insira a cidade para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCidade.Focus();
                    conexao.Close();
                }
                else if (txtNumero.Text == "Insira o número")
                {
                    MessageBox.Show("Insira o numero para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Focus();
                    conexao.Close();
                }
                else if (txtNumero.Text == "")
                {
                    MessageBox.Show("Insira o numero para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Focus();
                    conexao.Close();
                }
                else if (txtComplemento.Text == "Insira seu complemento")
                {
                    MessageBox.Show("Insira o complemento para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplemento.Focus();
                    conexao.Close();
                }
                else if (txtComplemento.Text == "")
                {
                    MessageBox.Show("Insira o complemento para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplemento.Focus();
                    conexao.Close();
                }
                else if (txtSenha.Text == "Crie uma senha")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Focus();
                    conexao.Close();
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Focus();
                    conexao.Close();
                }
                else if (txtConfirmacaoSenha.Text == "Confirmação de senha")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenha.Focus();
                    conexao.Close();
                }
                else if (txtConfirmacaoSenha.Text == "")
                {
                    MessageBox.Show("Insira a senha para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenha.Focus();
                    conexao.Close();
                }
                else if (txtSenha.Text != txtConfirmacaoSenha.Text)
                {
                    MessageBox.Show("Insira as senhas iguais para fazer o cadastro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmacaoSenha.Focus();
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

