using System;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class VoluntariaModel
    {

        DatabaseUtils databaseUtils = new DatabaseUtils();
        public object getVoluntariaById(String id)
        {
            String query = "SELECT * FROM Voluntario WHERE ID_Voluntario = " + id;

            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                reader.Read();
                Console.WriteLine(reader["ID_Voluntario"].ToString());
            }
            return reader.HasRows;
        }
    }
}
