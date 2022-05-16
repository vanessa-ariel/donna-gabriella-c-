using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnaGabriela.Modal
{
    
    public class ConexaoBD
    {
        private string conexaoString = @"Data Source=.\SQLEXPRESS;Database=DonnaGabriela;Trusted_Connection=True";


        public SqlConnection GetConnection()
        {
            return new SqlConnection(conexaoString);
        }
    }
}
