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
            String query = "SELECT Funcionario.*, Cargo.Nome_Cargo AS Cargo, Departamento.Nome_Depto AS Depto " +
                "FROM Funcionario " +
                "INNER JOIN Cargo ON Funcionario.ID_Cargo = Cargo.ID_Cargo " +
                "INNER JOIN Departamento ON Funcionario.ID_Depto = Departamento.ID_Depto " +
                "WHERE ID_Func = " + id;

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                funcionario.ID_Func = int.Parse(reader["ID_Func"].ToString());
                funcionario.ID_Cargo = int.Parse(reader["ID_Cargo"].ToString());
                funcionario.Cargo = reader["Cargo"].ToString();
                funcionario.ID_Depto = int.Parse(reader["ID_Depto"].ToString());
                funcionario.Depto = reader["Depto"].ToString();
                funcionario.Nome_Func = reader["Nome_Func"].ToString();
                funcionario.CPF_Func = reader["CPF_Func"].ToString();
                funcionario.RG_Func = reader["RG_Func"].ToString();
                funcionario.Telefone_Func = reader["Telefone_Func"].ToString();
                funcionario.Email_Func = reader["Email_Func"].ToString();
                funcionario.Cep_Func = reader["Cep_Func"].ToString();
                funcionario.Endereco_Func = reader["Endereco_Func"].ToString();
                funcionario.Numero_Func = reader["Numero_Func"].ToString();
                funcionario.Bairro_Func = reader["Bairro_Func"].ToString();
                funcionario.Cidade_Func = reader["Cidade_Func"].ToString();
                funcionario.Complemento_Func = reader["Complemento_Func"].ToString();
                funcionario.Data_Nasci_Func = reader["Data_Nasci_Func"].ToString();
                funcionario.Senha_User = reader["Senha_User"].ToString();
                funcionario.Data_Desligamento = reader["Data_Desligamento"].ToString();
                funcionario.Data_Admissao = reader["Data_Admissao"].ToString();
                funcionario.Status_Conta = reader["Status_Conta"].ToString();
            }
            return funcionario;
        }

        public SqlDataAdapter getFuncionariosByStatus(String status)
        {
            string query = "SELECT ID_Func, Nome_Func, Telefone_Func FROM Funcionario WHERE Status_Conta = '" + status + "'";

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }

        public Boolean editFuncionario(Funcionario funcionario)
        {
            String query = "UPDATE Funcionario SET " +
                                "Nome_Func = '" + funcionario.Nome_Func + "', " +
                                "Telefone_Func = '" + funcionario.Telefone_Func + "', " +
                                "Email_Func = '" + funcionario.Email_Func + "', " +
                                "Cep_Func = '" + funcionario.Cep_Func + "', " +
                                "Endereco_Func = '" + funcionario.Endereco_Func + "', " +
                                "Numero_Func = '" + funcionario.Numero_Func + "', " +
                                "Bairro_Func = '" + funcionario.Bairro_Func + "', " +
                                "Cidade_Func = '" + funcionario.Cidade_Func + "', " +
                                "Complemento_Func = '" + funcionario.Complemento_Func + "' " +
                            "WHERE ID_Func = " + funcionario.ID_Func;
            return databaseUtils.ExecuteCommand(query);
        }

        public Boolean deleteFuncionarioById(int id)
        {
            databaseUtils.openConnection();
            String query = "UPDATE Funcionario SET Status_Conta = 2 WHERE ID_Func = " + id;
            return databaseUtils.ExecuteCommand(query);
        }
    }
}
