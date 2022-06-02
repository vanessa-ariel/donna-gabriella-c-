using System;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class FuncionarioModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public Funcionario getFuncionarioById(int id)
        {
            Funcionario funcionario = new Funcionario();
            String query = "SELECT * FROM Voluntario WHERE ID_Voluntario = " + id;

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                funcionario.ID_Voluntario = int.Parse(reader["ID_Voluntario"].ToString());
                funcionario.ID_Servico = reader["ID_Servico"].ToString();
                funcionario.Nome_Servico = reader["Nome_Servico"].ToString();
                funcionario.Nome_Voluntario = reader["Nome_Voluntario"].ToString();
                funcionario.Telefone_Voluntario = reader["Telefone_Voluntario"].ToString();
                funcionario.Email_Voluntario = reader["Email_Voluntario"].ToString();
                funcionario.Cep_Voluntario = reader["Cep_Voluntario"].ToString();
                funcionario.Endereco_Voluntario = reader["Endereco_Voluntario"].ToString();
                funcionario.Numero_Voluntario = reader["Numero_Voluntario"].ToString();
                funcionario.Bairro_Voluntario = reader["Bairro_Voluntario"].ToString();
                funcionario.Cidade_Voluntario = reader["Cidade_Voluntario"].ToString();
                funcionario.Complemento_Voluntario = reader["Complemento_Voluntario"].ToString();
                funcionario.Data_Nasci_User = reader["Data_Nasci_User"].ToString();
                funcionario.Senha_Voluntario = reader["Senha_Voluntario"].ToString();
                funcionario.Sexo_Voluntario = reader["Sexo_Voluntario"].ToString();
                funcionario.Data_Cadastro = reader["Data_Cadastro"].ToString();
                funcionario.Data_Desligamento = reader["Data_Desligamento"].ToString();
                funcionario.Data_Admissao = reader["Data_Admissao"].ToString();
                funcionario.Status_Conta = reader["Status_Conta"].ToString();
            }
            return funcionario;
        }

        public SqlDataAdapter getFuncionariosByStatus(String status)
        {
            string query = "SELECT ID_Voluntario, Nome_Voluntario, Telefone_Voluntario FROM Voluntario WHERE Status_Conta = '" + status + "'";

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }

        public Boolean editFuncionario(Funcionario funcionario)
        {
            String query = "UPDATE Voluntario SET " +
                                "Nome_Servico = '" + funcionario.Nome_Servico + "', " +
                                "Nome_Voluntario = '" + funcionario.Nome_Voluntario + "', " +
                                "Telefone_Voluntario = '" + funcionario.Telefone_Voluntario + "', " +
                                "Email_Voluntario = '" + funcionario.Email_Voluntario + "', " +
                                "Cep_Voluntario = '" + funcionario.Cep_Voluntario + "', " +
                                "Endereco_Voluntario = '" + funcionario.Endereco_Voluntario + "', " +
                                "Numero_Voluntario = '" + funcionario.Numero_Voluntario + "', " +
                                "Bairro_Voluntario = '" + funcionario.Bairro_Voluntario + "', " +
                                "Cidade_Voluntario = '" + funcionario.Cidade_Voluntario + "', " +
                                "Complemento_Voluntario = '" + funcionario.Complemento_Voluntario + "' " +
                            "WHERE ID_Voluntario = " + funcionario.ID_Voluntario;
            return databaseUtils.ExecuteCommand(query);
        }

        public Boolean deleteFuncionarioById(int id)
        {
            databaseUtils.openConnection();
            String query = "UPDATE Voluntario SET Status_Conta = 1 WHERE ID_Voluntario = " + id;
            return databaseUtils.ExecuteCommand(query);
        }
    }
}
