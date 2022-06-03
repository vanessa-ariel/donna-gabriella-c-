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

        }
        private void populateFuncionarioForm()
        {
            cmbProfissoes.Text = funcionario.Nome_Servico;
            txtNome.Text = funcionario.Nome_Voluntario;
            txtCpf.Text = funcionario.Cpf_Voluntario;
            txtTelefone.Text = funcionario.Telefone_Voluntario;
            txtEmail.Text = funcionario.Email_Voluntario;
            txtcep.Text = funcionario.Cep_Voluntario;
            txtRua.Text = funcionario.Endereco_Voluntario;
            txtNumeroRua.Text = funcionario.Numero_Voluntario;
            txtBairro.Text = funcionario.Bairro_Voluntario;
            txtCidade.Text = funcionario.Cidade_Voluntario;
            txtComplemento.Text = funcionario.Complemento_Voluntario;
        }
    }
}
