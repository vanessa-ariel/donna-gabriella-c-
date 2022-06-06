using System;

namespace DonnaGabriela.Model
{
    class Usuaria
    {
        private int id_user;
        private String nome_user;
        private String cpf_user;
        private String telefone_user;
        private String email_user;
        private String cep_user;
        private String endereco_user;
        private String numero_user;
        private String bairro_user;
        private String cidade_user;
        private String complemento_user;
        private String data_nasci_user;
        private String data_cadastro;
        private String data_desligamento;
        private String data_admissao;
        private String status_conta;
        private String senha_user;

        public int ID_User { get => id_user; set => id_user = value; }
        public string Nome_User { get => nome_user; set => nome_user = value; }
        public string Cpf_User { get => cpf_user; set => cpf_user = value; }
        public string Telefone_User { get => telefone_user; set => telefone_user = value; }
        public string Email_User { get => email_user; set => email_user = value; }
        public string Cep_User { get => cep_user; set => cep_user = value; }
        public string Endereco_User { get => endereco_user; set => endereco_user = value; }
        public string Numero_User { get => numero_user; set => numero_user = value; }
        public string Bairro_User { get => bairro_user; set => bairro_user = value; }
        public string Cidade_User { get => cidade_user; set => cidade_user = value; }
        public string Complemento_User { get => complemento_user; set => complemento_user = value; }
        public string Data_Nasci_User { get => data_nasci_user; set => data_nasci_user = value; }
        public string Senha_User { get => senha_user; set => senha_user = value; }
        public string Data_Cadastro { get => data_cadastro; set => data_cadastro = value; }
        public string Data_Desligamento { get => data_desligamento; set => data_desligamento = value; }
        public string Data_Admissao { get => data_admissao; set => data_admissao = value; }
        public string Status_Conta { get => status_conta; set => status_conta = value; }
    }
}
