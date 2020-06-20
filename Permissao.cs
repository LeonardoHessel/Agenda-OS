using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public class Permissao:Conexao
    {
        private long ID_Usuario { get; set; }
        public long ID_Modulo { get; set; }
        public bool Acesso { get; set; }

        public static List<Permissao> CarregarPermissoes(long id_usuario)
        {
            string sql;
            sql = "SELECT `usuario` AS 'id_usuario',`modulo` AS 'id_modulo',`acesso` ";
            sql += "FROM `permissao` WHERE `usuario` = @id_usuario";
            Permissao permissao = new Permissao();
            permissao.NewCMD(sql, CommandType.Text);
            permissao.AddPar("id_usuario", id_usuario);
            DataTable tabela = permissao.GetTable();
            List<Permissao> listaPermissoes = new List<Permissao>();
            if (tabela != null)
            {
                listaPermissoes = (from DataRow dr in tabela.Rows select new Permissao() {
                    ID_Usuario = Convert.ToInt64(dr["id_usuario"]),
                    ID_Modulo = Convert.ToInt64(dr["id_modulo"]),
                    Acesso = Convert.ToBoolean(dr["acesso"])
                }).ToList();
                return listaPermissoes;
            }
            return null;
        }

        public static void SalvarPermissoes(List<Permissao> listaPermissoes)
        {
            foreach (var permissao in listaPermissoes)
            {
                string sql = "UPDATE `permissao` SET `acesso` = " + permissao.Acesso + " WHERE `usuario` = " + permissao.ID_Usuario + " AND `modulo` = " + permissao.ID_Modulo;
                MessageBox.Show(sql);
            }
        }
    }
}
