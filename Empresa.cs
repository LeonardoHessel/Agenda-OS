using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    class Empresa:Conexao
    {
        public long ID { get; set; }
        public string CNPJ { get; set; }
        public string Razao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public bool Deletado { get; set; }
        public List<Permissao> Permissoes { get; set; }

        //cadastro de empresas
        private bool Cadastrar()
        {
            string sql = "INSERT INTO `empresa` (`0`,`cnpj`,`razao`,`nome`,`endereco`,`cep`,`telefone`,`celular`,`del`)" + " VALUES(@CNPJ,@Razao,@Nome,@Endereco,@CEP,@Telefone,@Celular,@Deletado)";
            
            NewCMD(sql, CommandType.Text);
            AddPar("cnpj", this.CNPJ);
            AddPar("razao", this.Razao);
            AddPar("nome", this.Nome);
            AddPar("endereco", this.Endereco);
            AddPar("cep", this.CEP);
            AddPar("telefone", this.Telefone);
            AddPar("celular", this.Celular);
            AddPar("del", this.Deletado);
            
            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                return true;
            }
            return false;
        }
        
        
        //listagem das empresas
        public static List<Empresa> ListaEmpresa()
        {
            string sql;
            Empresa empresa = new Empresa();
           
            sql = "SELECT * FROM `empresa`";
            empresa.NewCMD(sql, CommandType.Text);
            
            DataTable table = empresa.GetTable();
            List<Empresa> listarempresa = new List<Empresa>();

                listarempresa = (from DataRow dr in table.Rows
                                 select new Empresa()
                                 {
                                     ID = Convert.ToInt64(dr["id"]),
                                     CNPJ = dr["cnpj"].ToString(),
                                     Razao = dr["razao"].ToString(),
                                     Nome = dr["nome"].ToString(),
                                     Endereco = dr["endereco"].ToString(),
                                     CEP = dr["cep"].ToString(),
                                     Telefone = dr["telefone"].ToString(),
                                     Celular = dr["celular"].ToString(),
                                 }).ToList();
                return listarempresa;
  
               
           
        }
    }
}
