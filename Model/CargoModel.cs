using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{
    class CargoModel
    {
        DatabaseUtils databaseUtils = new DatabaseUtils();

        public List<Cargo> getCargos()
        {
            List<Cargo> CargosList = new List<Cargo>();
            String query = "SELECT ID_Cargo, Nome_Cargo FROM Cargo";
            databaseUtils.openConnection();
            SqlDataReader reader = databaseUtils.ExecuteReader(query);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cargo cargo = new Cargo();
                    cargo.ID_Cargo = int.Parse(reader["ID_Cargo"].ToString());
                    cargo.Nome_Cargo = reader["Nome_Cargo"].ToString();

                    CargosList.Add(cargo);
                }
            }
            reader.Close();
            return CargosList;
        }
    }
}
