using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProva
{
    public class MarcasDAO
    {
        string textoConexao
        = "Server=(local)\\SQLEXPRESS;Database=BancoProva;Trusted_Connection=True;";

        // Função para Listar todos os estados
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Marcas order by Sigla";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
