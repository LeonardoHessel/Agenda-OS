using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Empresa:Conexao
    {
        public long ID_Empresa { get; set; }
        public string CNPJ { get; set; }
        public string Razao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public static List<Empresa> BuscaEmpresa(string busca, bool ativo)
        {
            string sql;
            Empresa con = new Empresa();
            if (busca != null)
            {
                sql = "SELECT * FROM `empresa` WHERE `del`= @del AND " +
                    "(`cnpj` like CONCAT('%',@busca,'%') OR " +
                    "`razao` like CONCAT('%',@busca,'%') OR " +
                    "`nome` like CONCAT('%',@busca,'%'));";
                con.NewCMD(sql, CommandType.Text);
                con.AddPar("busca", busca);
                con.AddPar("del", ativo);
            }
            else
            {
                sql = "SELECT * FROM `usuario`";
                con.NewCMD(sql, CommandType.Text);
            }
            DataTable table = con.GetTable();
            List<Empresa> lista = new List<Empresa>();
            if (table != null)
            {
                lista = (from DataRow dr in table.Rows select new Empresa() {
                    ID_Empresa = Convert.ToInt64(dr["id"]),
                    CNPJ = dr["cnpj"].ToString(),
                    Razao = dr["razao"].ToString(),
                    Nome = dr["nome"].ToString(),
                    Endereco = dr["endereco"].ToString(),
                    CEP = dr["cep"].ToString(),
                    Telefone = dr["telefone"].ToString(),
                    Celular = dr["celular"].ToString()
                }).ToList();
                return lista;
            }
            return null;
        }
    }
}
