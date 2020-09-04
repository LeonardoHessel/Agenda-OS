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

        public static List<Produto> TodosProdutos(string busca)
        {
            string sql;
            Produto Con = new Produto();
            sql = @"SELECT * FROM `produto` 
                WHERE `id` like CONCAT('%', @busca, '%') 
                OR `nome` like CONCAT('%', @busca, '%')";
            Con.NewCMD(sql, CommandType.Text);
            Con.AddPar("busca", busca);
            DataTable tabela = Con.GetTable();
            List<Produto> produtos = new List<Produto>();
            if (tabela != null)
            {
                produtos = (from DataRow row in tabela.Rows select new Produto()
                {
                    ID = Convert.ToInt64(row["id"]),
                    Nome = row["nome"].ToString(),
                    Ativo = Convert.ToBoolean(row["ativo"]),
                }).ToList();
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
