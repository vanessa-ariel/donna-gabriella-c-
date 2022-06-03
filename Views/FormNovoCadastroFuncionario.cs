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
    public partial class FormNovoCadastroFuncionario : Form
    {
        private Boolean editMode = false;
        private FuncionarioModel funcionarioModel = new FuncionarioModel();
        private Funcionario funcionario;

        public FormNovoCadastroFuncionario()
        {
            InitializeComponent();
        }

        public FormNovoCadastroFuncionario(int id)
        {
            InitializeComponent();
            editMode = true;
            funcionario = funcionarioModel.getFuncionarioById(id);
            populateFuncionarioForm();

            label1.Text = "Edição de Funcionário";
            btnCadastrarFunc.Text = "Salvar";
        }
        private void populateFuncionarioForm()
        {
            txtNome.Text = funcionario.Nome_Func;
            txtTelefone.Text = funcionario.Telefone_Func;
            txtEmail.Text = funcionario.Email_Func;
            txtCpf.Text = funcionario.CPF_Func;
            txtRg.Text = funcionario.RG_Func;
            txtAdmissao.Text = funcionario.Data_Admissao;
            txtCargo.Text = funcionario.Cargo;
            txtcep.Text = funcionario.Cep_Func;
            txtRua.Text = funcionario.Endereco_Func;
            txtNumeroRua.Text = funcionario.Numero_Func;
            txtBairro.Text = funcionario.Bairro_Func;
            txtCidade.Text = funcionario.Cidade_Func;
            txtComplemento.Text = funcionario.Complemento_Func;
        }
    }
}
