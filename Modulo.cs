using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    class Modulo:Conexao
    {
        public long ID_Modulo { get; set; }
        public string Descricao { get; set; }
        public bool Restricao { get; set; }

        public static bool TemRestricao(long id)
        {
            string sql;
            sql = "SELECT * FROM `modulo` WHERE `id` = @id";
            Modulo modulo = new Modulo();
            modulo.NewCMD(sql,CommandType.Text);
            modulo.AddPar("id", id);
            DataTable tabela = modulo.GetTable();
            List<Modulo> listaModulo = new List<Modulo>();
            if (tabela != null)
            {
                listaModulo = (from DataRow dr in tabela.Rows select new Modulo(){
                    ID_Modulo = Convert.ToInt64(dr["id"]),
                    Descricao = (dr["descricao"]).ToString(),
                    Restricao = Convert.ToBoolean(dr["restricao"])
                }).ToList();
            }
            return listaModulo[0].Restricao;
        }
    }
}
