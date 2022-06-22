using System;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class AgendamentoModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public SqlDataAdapter getAgendamentos()
        {
                string query = "SELECT DISTINCT S.Dia_Disponivel, format(S.Horario_Inicio, 'hh:mm'), format(S.Horario_Termino, 'hh:mm'), V.Nome_Voluntario, U.Nome_User, S.Nome_Servico " +
            "FROM Servico_Solicitado AS So  " +
            "INNER JOIN Servico S ON So.ID_Voluntario = S.ID_Voluntario AND Status_Servico = 0 " +
            "INNER JOIN Voluntario V  ON So.ID_Voluntario = V.ID_Voluntario " +
            "INNER JOIN Usuario U ON So.ID_User = U.ID_User";

            databaseUtils.openConnection();
            return databaseUtils.ExecuteAdapter(query);
        }
    }
}
