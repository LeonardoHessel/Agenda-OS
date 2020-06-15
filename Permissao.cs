using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    class Permissao:Conexao
    {
        private long Id_Usuario { get; set; }
        private long Id_Modulo { get; set; }
        private string Descricao { get; set; }
        private bool Acesso { get; set; }

        public static List<Permissao> CarregarPermissoes(int id_usuario)
        {
            string sql;
            sql = "SELECT `usuario`.`id` AS 'id_usuario',`modulo`.`id` AS 'id_modulo',`descricao`, `acesso` ";
            sql += "FROM `modulo` JOIN `usuario` JOIN `permissao` ";
            sql += "ON `usuario`.`id` = `permissao`.`usuario` ";
            sql += "AND `modulo`.`id` = `permissao`.`modulo` ";
            sql += "WHERE `usuario` = @id_usuario";
            Permissao permissao = new Permissao();
            permissao.NewCMD(sql, CommandType.Text);
            permissao.AddPar("id_usuario", id_usuario);
            DataTable tabela = permissao.GetTable();
            List<Permissao> listaPermissoes = new List<Permissao>();
            if (tabela != null)
            {
                listaPermissoes = (from DataRow dr in tabela.Rows select new Permissao() {
                    Id_Usuario = Convert.ToInt64(dr["id_usuario"]),
                    Id_Modulo = Convert.ToInt64(dr["id_modulo"]),
                    Descricao = dr["descricao"].ToString(),
                    Acesso = Convert.ToBoolean(dr["acesso"])
                }).ToList();
                return listaPermissoes;
            }
            return null;
        }
    }
}
