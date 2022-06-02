using System.Data;
using System.Data.SqlClient;

namespace DonnaGabriela.Model
{

    public class DatabaseUtils
    {
        private string databaseConnection = @"Data Source=.\SQLEXPRESS;Database=DonnaGabriela;Trusted_Connection=True";
        private SqlConnection connection;

        public void openConnection()
        {
            this.connection = new SqlConnection(databaseConnection);
            this.connection.Open();
        }

        public void closeConnection()
        {
            this.connection.Close();
        }

        public SqlDataReader ExecuteReader(string command)
        {
            SqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = command;
            return cmd.ExecuteReader();
        }

        public SqlDataAdapter ExecuteAdapter(string command)
        {
            return new SqlDataAdapter(command, this.connection);
        }

        public bool ExecuteCommand(string command)
        {
            SqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = command;
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
