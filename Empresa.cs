using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public class Empresa : Conexao
    {
        public long ID { get; set; }
        public string CNPJ { get; set; }
        public string Razao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        //public bool Deletado { get; set; }
        public List<Permissao> Permissoes { get; set; }

        //cadastro de empresas
        private bool Cadastrar()
        {
            string sql = "INSERT INTO `empresa` (`cnpj`,`razao`,`nome`,`endereco`,`cep`,`telefone`,`celular`)" + " VALUES(@CNPJ,@Razao,@Nome,@Endereco,@CEP,@Telefone,@Celular)";

            NewCMD(sql, CommandType.Text);
            AddPar("cnpj", this.CNPJ);
            AddPar("razao", this.Razao);
            AddPar("nome", this.Nome);
            AddPar("endereco", this.Endereco);
            AddPar("cep", this.CEP);
            AddPar("telefone", this.Telefone);
            AddPar("celular", this.Celular);
            //AddPar("del", this.Deletado);

            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                return true;
            }
            
            return false;
        }
        private bool Atualizar()
        {
            string sql =
                "UPDATE `empresa` SET `cnpj`= @cnpj, `razao`= @razao, `nome`= @nome,`endereco`= @endereco," +
                "`cep`= @cep,`telefone`= @telefone,`celular`= @celular WHERE `id`= @id";

            NewCMD(sql, CommandType.Text);
            AddPar("id", this.ID);
            AddPar("cnpj", this.CNPJ);
            AddPar("razao", this.Razao);
            AddPar("nome", this.Nome);
            AddPar("endereco", this.Endereco);
            AddPar("cep", this.CEP);
            AddPar("telefone", this.Telefone);
            AddPar("celular", this.Celular);

            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }

        //excluir empresa
        private bool Excluir(){
            string sql =
                "DELETE from `empresa` WHERE `empresa`.`id`= @id";

            NewCMD(sql, CommandType.Text);
            AddPar("id", this.ID);

            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }
        //listagem das empresas
        public static List<Empresa> ListaEmpresa()
        {
            string sql;
            Empresa empresa = new Empresa();

            sql = "SELECT id, cnpj, razao, nome, endereco, cep, telefone, celular FROM empresa";
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
        
        //tipo de ação
        public bool SalvarEmpresa(string action)
        {

            if (action == "New")
            {
                return Cadastrar();
            }
            else if (action == "Edit")
            {
                return Atualizar();
            }
            else if (action == "Delete") 
            {
                return Excluir();
            }
            return false;
        }
    }
}
