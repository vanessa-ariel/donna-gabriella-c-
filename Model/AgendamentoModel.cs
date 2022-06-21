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
                                "Data_Inicio, " +
                                //"Data_Inicio AS Hora_Inicio, " +
                                "Voluntario.Nome_Voluntario AS Nome_Voluntario, " +
                                "Usuario.Nome_User AS Nome_User, " +
                                "Servico.Nome_Servico AS Nome_Servico " +
                            "FROM Servico_Solicitado " +
                            "INNER JOIN Servico ON Servico_Solicitado.ID_Serv_Solicitado = Servico.ID_Servico " +
                            "INNER JOIN Usuario ON Servico_Solicitado.ID_User = Usuario.ID_User " +
                            "INNER JOIN Voluntario ON Servico_Solicitado.ID_Voluntario = Voluntario.ID_Voluntario";

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }
    }
}
