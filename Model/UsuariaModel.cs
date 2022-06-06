using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class UsuariaModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public Usuaria getUsuariaById(int id)
        {
            Usuaria usuaria = new Usuaria();
            String query = "SELECT * FROM Usuario WHERE ID_Usuario = " + id;

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                usuaria.ID_User = int.Parse(reader["ID_User"].ToString());
                usuaria.Nome_User = reader["Nome_User"].ToString();
                usuaria.Cpf_User = reader["CPF_User"].ToString();
                usuaria.Telefone_User = reader["Telefone_User"].ToString();
                usuaria.Email_User = reader["Email_User"].ToString();
                usuaria.Cep_User = reader["Cep_User"].ToString();
                usuaria.Endereco_User = reader["Endereco_User"].ToString();
                usuaria.Numero_User = reader["Numero_User"].ToString();
                usuaria.Bairro_User = reader["Bairro_User"].ToString();
                usuaria.Cidade_User = reader["Cidade_User"].ToString();
                usuaria.Complemento_User = reader["Complemento_User"].ToString();
                usuaria.Data_Nasci_User = reader["Data_Nasci_User"].ToString();
                usuaria.Data_Cadastro = reader["Data_Cadastro"].ToString();
                usuaria.Data_Admissao = reader["Data_Admissao"].ToString();
                usuaria.Data_Desligamento = reader["Data_Desligamento"].ToString();
                usuaria.Status_Conta = reader["Status_Conta"].ToString();
                usuaria.Senha_User = reader["Senha_User"].ToString();
            }
            reader.Close();
            return usuaria;
        }

        public SqlDataAdapter getUsuariasByStatus(String status)
        {
            string query = "SELECT ID_User, Nome_User, Telefone_User FROM User WHERE Status_Conta = " + status;

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }

        public List<Usuaria> getUsuariasPendentes()
        {
            List<Usuaria> UsuariasList = new List<Usuaria>();
            String query = "SELECT * FROM Usuario WHERE Status_Conta = 0";

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuaria usuaria = new Usuaria();
                    usuaria.ID_User = int.Parse(reader["ID_User"].ToString());
                    usuaria.Nome_User = reader["Nome_User"].ToString();
                    usuaria.Cpf_User = reader["CPF_User"].ToString();
                    usuaria.Telefone_User = reader["Telefone_User"].ToString();
                    usuaria.Email_User = reader["Email_User"].ToString();
                    usuaria.Cep_User = reader["Cep_User"].ToString();
                    usuaria.Endereco_User = reader["Endereco_User"].ToString();
                    usuaria.Numero_User = reader["Numero_User"].ToString();
                    usuaria.Bairro_User = reader["Bairro_User"].ToString();
                    usuaria.Cidade_User = reader["Cidade_User"].ToString();
                    usuaria.Complemento_User = reader["Complemento_User"].ToString();
                    usuaria.Data_Nasci_User = reader["Data_Nasci_User"].ToString();
                    usuaria.Data_Cadastro = reader["Data_Cadastro"].ToString();
                    usuaria.Data_Desligamento = reader["Data_Desligamento"].ToString();
                    usuaria.Data_Admissao = reader["Data_Admissao"].ToString();
                    usuaria.Status_Conta = reader["Status_Conta"].ToString();
                    usuaria.Senha_User = reader["Senha_User"].ToString();

                    UsuariasList.Add(usuaria);
                }
            }
            reader.Close();
            return UsuariasList;
        }

        public Boolean editUsuaria(Usuaria usuaria)
        {
            databaseUtils.openConnection();
            String query = "UPDATE Usuario SET " +
                                "Nome_User = '" + usuaria.Nome_User + "', " +
                                "Cpf_User = '" + usuaria.Cpf_User + "', " +
                                "Telefone_User = '" + usuaria.Telefone_User + "', " +
                                "Email_User = '" + usuaria.Email_User + "', " +
                                "Cep_User = '" + usuaria.Cep_User + "', " +
                                "Endereco_User = '" + usuaria.Endereco_User + "', " +
                                "Numero_User = '" + usuaria.Numero_User + "', " +
                                "Bairro_User = '" + usuaria.Bairro_User + "', " +
                                "Cidade_User = '" + usuaria.Cidade_User + "', " +
                                "Complemento_User = '" + usuaria.Complemento_User + "', " +
                                "Status_Conta = " + usuaria.Status_Conta + " " +
                            "WHERE ID_User = " + usuaria.ID_User;
            Console.WriteLine(query);
            return databaseUtils.ExecuteCommand(query);
        }

        public Boolean deleteUsuariaById(int id)
        {
            DateTime dateTime = DateTime.UtcNow.Date;

            databaseUtils.openConnection();
            String query = "UPDATE Usuario SET Status_Conta = 2, Data_Desligamento = '" + dateTime.ToString("dd/MM/yyyy") + "' WHERE ID_Usuario = " + id;
            return databaseUtils.ExecuteCommand(query);
        }
    }
}
