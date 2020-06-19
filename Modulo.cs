using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Modulo:Conexao
    {
        private long ID_Modulo { get; set; }
        private string Grupo { get; set; }
        private string Descricao { get; set; }
        private bool Restrito { get; set; }


        public static Modulo CarregarModulo(long id_modulo)
        {
            string sql = "SELECT * FROM `modulo` WHERE `id`=@id_modulo";
            Modulo modulo = new Modulo();
            modulo.NewCMD(sql, CommandType.Text);
            modulo.AddPar("id_modulo", id_modulo);
            DataRow linha = modulo.GetTable().Rows[1];
            modulo.ID_Modulo = linha.Field<long>("id");
            modulo.Grupo = linha.Field<string>("grupo");
            modulo.Descricao = linha.Field<string>("descricao");
            modulo.Restrito = linha.Field<bool>("restricao");
            return modulo;
        }

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
