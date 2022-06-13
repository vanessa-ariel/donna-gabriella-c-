using System;

namespace DonnaGabriela.Model
{
    class Funcionario
    {
        private int id_func;
        private int id_cargo;
        private String cargo;
        private int id_depto;
        private String depto;
        private String nome_func;
        private String telefone_func;
        private String email_func;
        private String cep_func;
        private String cpf_func;
        private String rg_func;
        private String endereco_func;
        private String numero_func;
        private String bairro_func;
        private String cidade_func;
        private String complemento_func;
        private String data_nasci_func;
        private String senha_func;
        private String data_desligamento;
        private String data_admissao;
        private String status_conta;

        public int ID_Func { get => id_func; set => id_func = value; }
        public int ID_Cargo { get => id_cargo; set => id_cargo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int ID_Depto { get => id_depto; set => id_depto = value; }
        public string Depto { get => depto; set => depto = value; }
        public string CPF_Func { get => cpf_func; set => cpf_func = value; }
        public string RG_Func { get => rg_func; set => rg_func = value; }
        public string Nome_Func { get => nome_func; set => nome_func = value; }
        public string Telefone_Func { get => telefone_func; set => telefone_func = value; }
        public string Email_Func { get => email_func; set => email_func = value; }
        public string Cep_Func { get => cep_func; set => cep_func = value; }
        public string Endereco_Func { get => endereco_func; set => endereco_func = value; }
        public string Numero_Func { get => numero_func; set => numero_func = value; }
        public string Bairro_Func { get => bairro_func; set => bairro_func = value; }
        public string Cidade_Func { get => cidade_func; set => cidade_func = value; }
        public string Complemento_Func { get => complemento_func; set => complemento_func = value; }
        public string Data_Nasci_Func { get => data_nasci_func; set => data_nasci_func = value; }
        public string Senha_Func { get => senha_func; set => senha_func = value; }
        public string Data_Desligamento { get => data_desligamento; set => data_desligamento = value; }
        public string Data_Admissao { get => data_admissao; set => data_admissao = value; }
        public string Status_Conta { get => status_conta; set => status_conta = value; }
    }
}
