﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SistemaProva.Suporte
{
    public class Conexao
    {
           public SqlConnection conexao = null;
        public Conexao()
        {
            conexao = new SqlConnection(
            ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
        }

        internal static object Query<T>(string v, object value)
        {
            throw new NotImplementedException();
        }
    }
}

