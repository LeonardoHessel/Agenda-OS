using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Produto:Conexao
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public bool Inserir()
        {
            string sql = "INSERT INTO `produto` (`nome`) values (@nome)";
            NewCMD(sql, CommandType.Text);
            AddPar("nome", this.Nome);
            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                return true;
            }
            return false;
        }

        public bool Atualizar()
        {
            string sql = @"UPDATE `produto` SET `nome` = @nome WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("nome", this.Nome);
            AddPar("id", this.ID);
            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }

        public static List<Produto> TodosProdutos(string status = "Todos", string busca = "", bool addTodos = false)
        {
            bool ativo = true;
            if (status == "Inativos")
                ativo = false;

            if (busca == null)
                busca = "";

            string sql;
            sql = @"SELECT * FROM `produto` 
            WHERE (`id` like CONCAT('%', @busca, '%') 
            OR `nome` like CONCAT('%', @busca, '%'))";

            if (status != "Todos")
                sql += " AND `ativo` = @ativo";

            Produto con = new Produto();
            con.NewCMD(sql, CommandType.Text);
            con.AddPar("busca", busca);

            if (status != "Todos" && status != null)
                con.AddPar("ativo", ativo);

            DataTable tabela = con.GetTable();
            List<Produto> produtos = new List<Produto>();
            if (tabela != null)
            {
                produtos = (from DataRow row in tabela.Rows select new Produto()
                {
                    ID = Convert.ToInt64(row["id"]),
                    Nome = row["nome"].ToString(),
                    Ativo = Convert.ToBoolean(row["ativo"]),
                }).ToList();

                if (addTodos)
                {
                    con.ID = 0;
                    con.Nome = "Todos";
                    produtos.Add(con);
                }

                return produtos;
            }
            return null;
        }

        public bool AlterarStatus()
        {
            string sql = "UPDATE `produto` SET `ativo` = @status WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("status", !this.Ativo);
            AddPar("id", this.ID);

            if (ExecuteNQ())
            {
                this.Ativo = !this.Ativo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
