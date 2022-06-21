using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class VoluntariaModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public Voluntaria getVoluntariaById(int id)
        {
            Voluntaria voluntaria = new Voluntaria();
            String query = "SELECT * FROM Voluntario WHERE ID_Voluntario = " + id;

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                voluntaria.ID_Voluntario = int.Parse(reader["ID_Voluntario"].ToString());
                //voluntaria.ID_Servico = reader["ID_Servico"].ToString();
                voluntaria.Nome_Servico = reader["Nome_Servico"].ToString();
                voluntaria.Nome_Voluntario = reader["Nome_Voluntario"].ToString();
                voluntaria.Cpf_Voluntario = reader["CPF_Voluntario"].ToString();
                voluntaria.Telefone_Voluntario = reader["Telefone_Voluntario"].ToString();
                voluntaria.Email_Voluntario = reader["Email_Voluntario"].ToString();
                voluntaria.Cep_Voluntario = reader["Cep_Voluntario"].ToString();
                voluntaria.Endereco_Voluntario = reader["Endereco_Voluntario"].ToString();
                voluntaria.Numero_Voluntario = reader["Numero_Voluntario"].ToString();
                voluntaria.Bairro_Voluntario = reader["Bairro_Voluntario"].ToString();
                voluntaria.Cidade_Voluntario = reader["Cidade_Voluntario"].ToString();
                voluntaria.Complemento_Voluntario = reader["Complemento_Voluntario"].ToString();
                //voluntaria.Data_Nasci_Voluntario = reader["Data_Nasci_Voluntario"].ToString();
                voluntaria.Senha_Voluntario = reader["Senha_Voluntario"].ToString();
                voluntaria.Data_Cadastro = reader["Data_Cadastro"].ToString();
                voluntaria.Data_Desligamento = reader["Data_Desligamento"].ToString();
                voluntaria.Data_Admissao = reader["Data_Admissao"].ToString();
                voluntaria.Status_Conta = reader["Status_Conta"].ToString();
            }
            reader.Close();
            return voluntaria;
        }

        public SqlDataAdapter getVoluntariasByStatus(String status)
        {
            string query = "SELECT Nome_Voluntario,ID_Voluntario, CPF_Voluntario, Nome_Servico FROM Voluntario WHERE Status_Conta = " + status;

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }

        public List<Voluntaria> getVoluntariasPendentes()
        {
            List<Voluntaria> voluntariasList = new List<Voluntaria>();
            String query = "SELECT * FROM Voluntario WHERE Status_Conta = 0";

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Voluntaria voluntaria = new Voluntaria();
                    voluntaria.ID_Voluntario = int.Parse(reader["ID_Voluntario"].ToString());
                    voluntaria.Nome_Servico = reader["Nome_Servico"].ToString();
                    voluntaria.Nome_Voluntario = reader["Nome_Voluntario"].ToString();
                    voluntaria.Cpf_Voluntario = reader["CPF_Voluntario"].ToString();
                    voluntaria.Telefone_Voluntario = reader["Telefone_Voluntario"].ToString();
                    voluntaria.Email_Voluntario = reader["Email_Voluntario"].ToString();
                    voluntaria.Cep_Voluntario = reader["Cep_Voluntario"].ToString();
                    voluntaria.Endereco_Voluntario = reader["Endereco_Voluntario"].ToString();
                    voluntaria.Numero_Voluntario = reader["Numero_Voluntario"].ToString();
                    voluntaria.Bairro_Voluntario = reader["Bairro_Voluntario"].ToString();
                    voluntaria.Cidade_Voluntario = reader["Cidade_Voluntario"].ToString();
                    voluntaria.Complemento_Voluntario = reader["Complemento_Voluntario"].ToString();
                    //voluntaria.Data_Nasci_Voluntario = reader["Data_Nasci_Voluntario"].ToString();
                    voluntaria.Senha_Voluntario = reader["Senha_Voluntario"].ToString();
                    voluntaria.Data_Cadastro = reader["Data_Cadastro"].ToString();
                    voluntaria.Data_Desligamento = reader["Data_Desligamento"].ToString();
                    voluntaria.Data_Admissao = reader["Data_Admissao"].ToString();
                    voluntaria.Status_Conta = reader["Status_Conta"].ToString();

                    voluntariasList.Add(voluntaria);
                }
            }
            reader.Close();
            return voluntariasList;
        }

        public Boolean editVoluntaria(Voluntaria voluntaria)
        {
            databaseUtils.openConnection();
            String query = "UPDATE Voluntario SET " +
                                "Nome_Servico = '" + voluntaria.Nome_Servico + "', " +
                                "Nome_Voluntario = '" + voluntaria.Nome_Voluntario + "', " +
                                "Cpf_Voluntario = '" + voluntaria.Cpf_Voluntario + "', " +
                                "Telefone_Voluntario = '" + voluntaria.Telefone_Voluntario + "', " +
                                "Email_Voluntario = '" + voluntaria.Email_Voluntario + "', " +
                                "Cep_Voluntario = '" + voluntaria.Cep_Voluntario + "', " +
                                "Endereco_Voluntario = '" + voluntaria.Endereco_Voluntario + "', " +
                                "Numero_Voluntario = '" + voluntaria.Numero_Voluntario + "', " +
                                "Bairro_Voluntario = '" + voluntaria.Bairro_Voluntario + "', " +
                                "Cidade_Voluntario = '" + voluntaria.Cidade_Voluntario + "', " +
                                "Complemento_Voluntario = '" + voluntaria.Complemento_Voluntario + "', " +
                                "Status_Conta = " + voluntaria.Status_Conta + " " +
                            "WHERE ID_Voluntario = " + voluntaria.ID_Voluntario;
            Console.WriteLine(query);
            return databaseUtils.ExecuteCommand(query);
        }

        public Boolean deleteVoluntariaById(int id)
        {
            DateTime dateTime = DateTime.UtcNow.Date;

            databaseUtils.openConnection();
            String query = "UPDATE Voluntario SET Status_Conta = 2, Data_Desligamento = '" + dateTime.ToString("dd/MM/yyyy") + "' WHERE ID_Voluntario = " + id;
            return databaseUtils.ExecuteCommand(query);
        }
    }
}
