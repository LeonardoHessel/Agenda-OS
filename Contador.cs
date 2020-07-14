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

        private string acao;

        public string Acao
        {
            get { return acao; }
            set 
            {
                acao = value;
                //CarregarContador();
            }
        }

        public void CarregarContador()
        {
            if (this.Acao == "get")
            {
                string sql = "SELECT * FROM `contador` WHERE `id` = :@id";
                NewCMD(sql, CommandType.Text);
                AddPar("id", this.ID);
                DataTable contador = GetTable();
            }
        }
    }
}
