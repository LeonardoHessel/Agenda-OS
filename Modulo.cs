using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    class Modulo:Conexao
    {
        private long ID_Modulo { get; set; }
        private string Grupo { get; set; }
        private string Descricao { get; set; }
        private bool Restrito { get; set; }

        public static List<Modulo> CarregarModulos()
        {
            string sql;
            sql = "SELECT `id` AS 'id_modulo',`grupo`,`descricao`,`restricao` FROM `modulo`";
            Modulo modulo = new Modulo();
            modulo.NewCMD(sql,CommandType.Text);
            DataTable tabela = modulo.GetTable();
            List<Modulo> listaModulo = new List<Modulo>();
            if (tabela != null)
            {
                listaModulo = (from DataRow dr in tabela.Rows select new Modulo() {
                    ID_Modulo = Convert.ToInt64(dr["id_modulo"]),
                    Grupo = dr["grupo"].ToString(),
                    Descricao = dr["descricao"].ToString(),
                    Restrito = Convert.ToBoolean(dr["restricao"])
                }).ToList();
                return listaModulo;
            }
            return null;
        }
    }
}
