using System;
using System.Windows.Forms;
using DonnaGabriela.Model;
using DonnaGabriela.InputValidations;
using DonnaGabriela.Views;

namespace DonnaGabriela
{
    public partial class FormEdicaoVoluntaria : Form
    {
        private Boolean editMode = false;
        private VoluntariaModel voluntariaModel = new VoluntariaModel();
        private Voluntaria voluntaria;

        public FormEdicaoVoluntaria()
        {
            InitializeComponent();
        }
        public FormEdicaoVoluntaria(int editId)
        {
            InitializeComponent();
            editMode = true;
            voluntaria = voluntariaModel.getVoluntariaById(editId);
            populateVoluntariaForm();
        }

        private void btnCadastrarVol_Click(object sender, EventArgs e)
        {
            //VALIDA OS CAMPOS SE PRECISAR
            this.updateVoluntaria();
            var owner = this.Owner as FormAdministrativo;
            if (editMode)
            {
                voluntariaModel.editVoluntaria(voluntaria);
                owner.loadDataTable();
                this.Close();
                return;
            }
        }

        private void populateVoluntariaForm()
        {
            cmbProfissoes.Text = voluntaria.Nome_Servico;
            txtNome.Text = voluntaria.Nome_Voluntario;
            txtCpf.Text = voluntaria.Cpf_Voluntario;
            txtTelefone.Text = voluntaria.Telefone_Voluntario;
            txtEmail.Text = voluntaria.Email_Voluntario;
            txtcep.Text = voluntaria.Cep_Voluntario;
            txtRua.Text = voluntaria.Endereco_Voluntario;
            txtNumeroRua.Text = voluntaria.Numero_Voluntario;
            txtBairro.Text = voluntaria.Bairro_Voluntario;
            txtCidade.Text = voluntaria.Cidade_Voluntario;
            txtComplemento.Text = voluntaria.Complemento_Voluntario;
        }

        private void updateVoluntaria()
        {
            voluntaria.Nome_Servico = cmbProfissoes.Text;
            voluntaria.Nome_Voluntario = txtNome.Text;
            voluntaria.Cpf_Voluntario = txtCpf.Text;
            voluntaria.Telefone_Voluntario = txtTelefone.Text;
            voluntaria.Email_Voluntario = txtEmail.Text;
            voluntaria.Cep_Voluntario = txtcep.Text;
            voluntaria.Endereco_Voluntario = txtRua.Text;
            voluntaria.Numero_Voluntario = txtNumeroRua.Text;
            voluntaria.Bairro_Voluntario = txtBairro.Text;
            voluntaria.Cidade_Voluntario = txtCidade.Text;
            voluntaria.Complemento_Voluntario = txtComplemento.Text;
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
