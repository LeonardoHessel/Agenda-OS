using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    class OS : Conexao
    {
        public long ID { get; set; }
        public string Empresa { get; set; }
        public string Solicitante { get; set; }
        public string Usuario { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public string Produto { get; set; }
        public string Atendimento { get; set; }
        public string Abertura { get; set; }
        public string Fechamento { get; set; }
        public string Status { get; set; }
        public bool Del { get; set; }
        public List<Permissao> Permissoes { get; set; }

        //Listagem de OS
        public static List<OS> ListarOS()
        {
            string sql;
            OS os = new OS();

             sql = "SELECT id, empresa, solicitante, usuario, assunto, descricao, solucao, produto, atendimento, abertura, fechamento, status FROM os";
             os.NewCMD(sql, CommandType.Text);

                DataTable table = os.GetTable();
                List<OS> listar_os = new List<OS>();

            listar_os = (from DataRow dr in table.Rows
                                 select new OS()
                                 {
                                     ID = Convert.ToInt64(dr["id"]),
                                     Empresa = dr["empresa"].ToString(),
                                     Solicitante = dr["solicitante"].ToString(),
                                     Usuario = dr["usuario"].ToString(),
                                     Assunto = dr["assunto"].ToString(),
                                     Descricao = dr["descricao"].ToString(),
                                     Solucao = dr["solucao"].ToString(),
                                     Produto = dr["produto"].ToString(),
                                     Atendimento = dr["atendimento"].ToString(),
                                     Abertura = dr["abertura"].ToString(),
                                     Status = dr["status"].ToString(),
                                 }).ToList();

             return listar_os;

        }

    }
}
