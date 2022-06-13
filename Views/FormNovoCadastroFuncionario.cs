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
using DonnaGabriela.InputValidations;
using DonnaGabriela.Views;

namespace DonnaGabriela
{
    public partial class FormNovoCadastroFuncionario : Form
    {
        private Boolean editMode = false;
        private FuncionarioModel funcionarioModel = new FuncionarioModel();
        private Funcionario funcionario;
        private CargoModel cargoModel = new CargoModel();
        private List<Cargo> cargosList = new List<Cargo>();

        public FormNovoCadastroFuncionario()
        {
            InitializeComponent();
            populateCargoField();
            funcionario = new Funcionario();
        }

        public FormNovoCadastroFuncionario(int id)
        {
            InitializeComponent();
            editMode = true;
            populateCargoField();
            funcionario = funcionarioModel.getFuncionarioById(id);
            populateFuncionarioForm();

            label1.Text = "Edição de Funcionário";
            btnCadastrarFunc.Text = "Salvar";
            passwordPanel.Visible = false;
        }

        private void populateCargoField()
        {
            cargosList = cargoModel.getCargos();
            cmbCargo.DataSource = cargosList;
            cmbCargo.DisplayMember = "Nome_Cargo";
            cmbCargo.ValueMember = "ID_Cargo";
        }
 
        private void populateFuncionarioForm()
        {
            txtNome.Text = funcionario.Nome_Func;
            txtTelefone.Text = funcionario.Telefone_Func;
            txtEmail.Text = funcionario.Email_Func;
            txtCpf.Text = funcionario.CPF_Func;
            txtRg.Text = funcionario.RG_Func;
            txtAdmissao.Text = funcionario.Data_Admissao;
            cmbCargo.Text = funcionario.Cargo;
            txtcep.Text = funcionario.Cep_Func;
            txtRua.Text = funcionario.Endereco_Func;
            txtNumeroRua.Text = funcionario.Numero_Func;
            txtBairro.Text = funcionario.Bairro_Func;
            txtCidade.Text = funcionario.Cidade_Func;
            txtComplemento.Text = funcionario.Complemento_Func;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            var owner = this.Owner as FormAdministrativoFuncionarios;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Preencha o campo E-mail", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
                return;
            }
            else if (txtRg.Text == "")
            {
                MessageBox.Show("Preencha o campo RG", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefone.Focus();
                return;
            }
            else if (txtAdmissao.Text == "")
            {
                MessageBox.Show("Preencha o campo Data de Admissão", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcep.Focus();
                return;
            }
            else if (cmbCargo.Text == "")
            {
                MessageBox.Show("Preencha o campo Cargo", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcep.Focus();
                return;
            }
            else if (txtRua.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome do Logradouro", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRua.Focus();
                return;
            }
            else if (txtNumeroRua.Text == "")
            {
                MessageBox.Show("Preencha o campo № da rua", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRua.Focus();
                return;
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Preencha o campo Bairro", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return;
            }
            else if (txtcep.Text == "")
            {
                MessageBox.Show("Preencha o campo Cep", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return;
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Preencha o campo Cidade", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return;
            }
            else if (!editMode)
                {

                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplemento.Focus();
                    return;
                }
                else if (txtConfirmacaoSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Confirmação Senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplemento.Focus();
                    return;
                }
                else if (txtSenha.Text != txtConfirmacaoSenha.Text)
                {
                    MessageBox.Show("As senhas devem ser iguais", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComplemento.Focus();
                    return;
                }
            }

            this.updateFuncionario();
            if (editMode)
            {
                funcionarioModel.editFuncionario(funcionario);
                owner.loadDataTable();
                this.Close();
                return;
            }
            funcionarioModel.createFuncionario(funcionario);
            owner.loadDataTable();
            this.Close();
            return;
        }

        private void updateFuncionario()
        {
            funcionario.Nome_Func = txtNome.Text;
            funcionario.Telefone_Func = txtTelefone.Text;
            funcionario.Email_Func = txtEmail.Text;
            funcionario.CPF_Func = txtCpf.Text;
            funcionario.RG_Func = txtRg.Text;
            funcionario.Data_Admissao = txtAdmissao.Text;
            funcionario.Cargo = cmbCargo.Text;
            funcionario.ID_Cargo = cmbCargo.SelectedIndex;
            funcionario.Cep_Func = txtcep.Text;
            funcionario.Endereco_Func = txtRua.Text;
            funcionario.Numero_Func = txtNumeroRua.Text;
            funcionario.Bairro_Func = txtBairro.Text;
            funcionario.Cidade_Func = txtCidade.Text;
            funcionario.Complemento_Func = txtComplemento.Text;
            funcionario.Senha_Func = txtSenha.Text;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);
        }

        private void txtAdmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);
        }

        private void txtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);
        }

        private void txtNumeroRua_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputs v = new ValidateInputs();
            v.AllowOnlyNumbers(e);
        }
    }
}
