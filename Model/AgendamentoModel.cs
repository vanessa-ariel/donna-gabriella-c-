using System;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class AgendamentoModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public SqlDataAdapter getAgendamentos()
        {
            string query = "SELECT " +
                                "Data_Solicitacao, " +
                                "Data_Solicitacao AS Hora_Solicitacao, " +
                                "Voluntario.Nome_Voluntario AS Nome_Voluntario, " +
                                "Usuario.Nome_User AS Nome_User, " +
                                "Servico.Nome_Serviço AS Nome_Serviço " +
                            "FROM Servico_Solicitado " +
                            "INNER JOIN Servico ON Servico_Solicitado.ID_Servico = Servico.ID_Servico " +
                            "INNER JOIN Usuario ON Servico_Solicitado.ID_User = Usuario.ID_User " +
                            "INNER JOIN Voluntario ON Servico_Solicitado.ID_Voluntario = Voluntario.ID_Voluntario";

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }
    }
}
