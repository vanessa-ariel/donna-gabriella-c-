using System;

namespace DonnaGabriela.Model
{
    class Voluntaria
    {
        private int id_voluntario;
        private String id_servico;
        private String nome_servico;
        private String nome_voluntario;
        private String telefone_voluntario;
        private String email_voluntario;
        private String cep_voluntario;
        private String endereco_voluntario;
        private String numero_voluntario;
        private String bairro_voluntario;
        private String cidade_voluntario;
        private String complemento_voluntario;
        private String data_nasci_User;
        private String senha_voluntario;
        private String sexo_voluntario;
        private String data_cadastro;
        private String data_desligamento;
        private String data_admissao;
        private String status_conta;

        public int ID_Voluntario { get => id_voluntario; set => id_voluntario = value; }
        public string ID_Servico { get => id_servico; set => id_servico = value; }
        public string Nome_Servico { get => nome_servico; set => nome_servico = value; }
        public string Nome_Voluntario { get => nome_voluntario; set => nome_voluntario = value; }
        public string Telefone_Voluntario { get => telefone_voluntario; set => telefone_voluntario = value; }
        public string Email_Voluntario { get => email_voluntario; set => email_voluntario = value; }
        public string Cep_Voluntario { get => cep_voluntario; set => cep_voluntario = value; }
        public string Endereco_Voluntario { get => endereco_voluntario; set => endereco_voluntario = value; }
        public string Numero_Voluntario { get => numero_voluntario; set => numero_voluntario = value; }
        public string Bairro_Voluntario { get => bairro_voluntario; set => bairro_voluntario = value; }
        public string Cidade_Voluntario { get => cidade_voluntario; set => cidade_voluntario = value; }
        public string Complemento_Voluntario { get => complemento_voluntario; set => complemento_voluntario = value; }
        public string Data_Nasci_User { get => data_nasci_User; set => data_nasci_User = value; }
        public string Senha_Voluntario { get => senha_voluntario; set => senha_voluntario = value; }
        public string Sexo_Voluntario { get => sexo_voluntario; set => sexo_voluntario = value; }
        public string Data_Cadastro { get => data_cadastro; set => data_cadastro = value; }
        public string Data_Desligamento { get => data_desligamento; set => data_desligamento = value; }
        public string Data_Admissao { get => data_admissao; set => data_admissao = value; }
        public string Status_Conta { get => status_conta; set => status_conta = value; }
    }
}
