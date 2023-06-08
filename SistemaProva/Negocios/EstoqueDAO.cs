using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaProva.Suporte;
using Dapper;

namespace SistemaProva
{
    public class EstoqueDAO : Conexao
    {
        //Função para Adicionar Nova Cidade
        public void Adicionar(string nome, string sigla)
        {
            conexao.Execute("INSERT INTO Estoque (Nome, Sigla) VALUES (@Nome, @Sigla)",
            new { nome, sigla });
        }
        // Função para Atualizar uma Cidade
        public void Atualizar(int id, string nome, string sigla)
        {
            conexao.Execute("UPDATE Estoque SET Nome=@Nome, Sigla=@Sigla WHERE ID=@ID",
            new { nome, sigla, id });
        }
        // Função para Excluir uma Cidade
        public void Excluir(int id)
        {
            conexao.Execute("DELETE FROM Estoque WHERE ID=@ID",
            new { id });
        }
        // Função para Buscar uma Cidade pelo ID
        public Estoque Buscar(int id)
        {
            return conexao.Query<Estoque>("SELECT * FROM Estoque WHERE ID=@ID",
            new { id }).SingleOrDefault();
        }
        // Função para Listar Todas as Cidades (foi modificado para ficar no padrão
        public List<Estoque> ListarTodas()

        {
            return conexao.Query<Estoque>("SELECT * FROM Estoque order by ID").ToList();
        }
    }
}
