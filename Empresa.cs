using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Empresa:Conexao
    {
        public long ID { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string Razao { get; set; }
        public string Nome { get; set; }
        public string Regime { get; set; }
        public Contador Contador { get; set; }
        public long ID_Contador { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
        public bool Del { get; set; }

        public static List<Empresa> BuscaEmpresa(string busca, bool ativo)
        {
            string sql;
            Empresa con = new Empresa();
            if (busca != null)
            {
                sql = "SELECT * FROM `empresa` WHERE `del`= @del AND " +
                    "(`cnpj` like CONCAT('%',@busca,'%') OR " +
                    "`razao` like CONCAT('%',@busca,'%') OR " +
                    "`nome` like CONCAT('%',@busca,'%'));";
                con.NewCMD(sql, CommandType.Text);
                con.AddPar("busca", busca);
                con.AddPar("del", ativo);
            }
            else
            {
                sql = "SELECT * FROM `usuario`";
                con.NewCMD(sql, CommandType.Text);
            }
            DataTable table = con.GetTable();
            List<Empresa> lista = new List<Empresa>();
            if (table != null)
            {
                lista = (from DataRow dr in table.Rows select new Empresa() {
                    ID = Convert.ToInt64(dr["id"]),
                    CNPJ = dr["cnpj"].ToString(),
                    IE = dr["ie"].ToString(),
                    Razao = dr["razao"].ToString(),
                    Nome = dr["nome"].ToString(),
                    Regime = dr["regime"].ToString(),
                    ID_Contador = Convert.ToInt64(dr["contador"]),
                    Logradouro = dr["logradouro"].ToString(),
                    Numero = dr["numero"].ToString(),
                    Complemento = dr["complemento"].ToString(),
                    CEP = dr["cep"].ToString(),
                    Bairro = dr["bairro"].ToString(),
                    Municipio = dr["municipio"].ToString(),
                    UF = dr["uf"].ToString(),
                    Email = dr["email"].ToString(),
                    Telefone = dr["telefone"].ToString(),
                    Observacao = dr["observacao"].ToString(),
                    Del = Convert.ToBoolean(dr["del"])
                }).ToList();
                return lista;
            }
            return null;
        }

        public bool SalvarEmpresa(string action)
        {

            if (action == "Novo")
            {
                return Cadastrar();
            }
            else if (action == "Atualizar")
            {
                return Atualizar();
            }
            return false;
        }

        private bool Cadastrar()
        {
            string sql = "INSERT INTO `empresa` (`cnpj`,`ie`,`razao`,`nome`,`regime`,`contador`,`logradouro`," +
                "`numero`,`complemento`,`cep`,`bairro`,`municipio`,`uf`,`email`,`telefone`,`observacao`) VALUES (" +
                "@cnpj,@ie,@razao,@nome,@regime,@contador,@logradouro,@numero,@complemento,@cep,@bairro," +
                "@municipio,@uf,@email,@telefone,@observacao)";
            NewCMD(sql, CommandType.Text);
            AddPar("cnpj", this.CNPJ);
            AddPar("ie",this.IE);
            AddPar("razao",this.Razao);
            AddPar("nome", this.Nome);
            AddPar("regime", this.Regime);
            AddPar("contador", this.ID_Contador);
            AddPar("logradouro", this.Logradouro);
            AddPar("numero", this.Numero);
            AddPar("complemento", this.Complemento);
            AddPar("cep", this.CEP);
            AddPar("bairro", this.Bairro);
            AddPar("municipio", this.Municipio);
            AddPar("uf", this.UF);
            AddPar("email", this.Email);
            AddPar("telefone", this.Telefone);
            AddPar("observacao", this.Observacao);
            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Atualizar()
        {
            string sql = "UPDATE `empresa` SET `cnpj`=@cnpj,`ie`=@ie,`razao`=@razao,`nome`=@nome,`regime`=@regime," +
                "`contador`=@contador,`logradouro`=@logradouro,`numero`=@numero,`complemento`=@complemento,`cep`=@cep," +
                "`bairro`=@bairro,`municipio`=@municipio,`uf`=@uf,`email`=@email,`telefone`=@telefone,`observacao`=@observacao," +
                "`del`=@del WHERE `id`=@id";
            NewCMD(sql, CommandType.Text);
            AddPar("id", this.ID);
            AddPar("cnpj", this.CNPJ);
            AddPar("ie", this.IE);
            AddPar("razao", this.Razao);
            AddPar("nome", this.Nome);
            AddPar("regime", this.Regime);
            AddPar("contador", this.ID_Contador);
            AddPar("logradouro", this.Logradouro);
            AddPar("numero", this.Numero);
            AddPar("complemento", this.Complemento);
            AddPar("cep", this.CEP);
            AddPar("bairro", this.Bairro);
            AddPar("municipio", this.Municipio);
            AddPar("uf", this.UF);
            AddPar("email", this.Email);
            AddPar("telefone", this.Telefone);
            AddPar("observacao", this.Observacao);
            AddPar("del", this.Del);
            if (ExeGetId())
            {
                return true;
            }
            return false;
        }
    }
}
