using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Contador:Conexao
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public static List<Contador> CarregarContadores()
        {
            Contador cont = new Contador();
            string sql = "SELECT * FROM `contador`";
            cont.NewCMD(sql, CommandType.Text);
            DataTable contador = cont.GetTable();
            List<Contador> lista = new List<Contador>();
            if (contador != null)
            {
                lista = (from DataRow dr in contador.Rows select new Contador()
                {
                    ID = Convert.ToInt64(dr["id"]),
                    Nome = dr["nome"].ToString(),
                    Telefone = dr["telefone"].ToString(),
                    Email = dr["email"].ToString()
                }).ToList();
                return lista;
            }
            return null;
        }


    }
}
