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
        public long ID_Contador { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        public static Empresa BuscaEmpresaByID(long empresaId)
        {
            Empresa con = new Empresa();
            string sql = @"SELECT * FROM `empresa` WHERE `id`=@id";
            con.NewCMD(sql, CommandType.Text);
            con.AddPar("id", empresaId);
            return con.TableToCustomers(con.GetTable())[0];
        }

        public static List<Empresa> BuscaEmpresa(string status, string busca)
        {
            bool ativo = false;
            if (status == "Ativos")
                ativo = true;

            string sqladd = " WHERE ";
            string sql = "SELECT * FROM `empresa`";
            if (status != "Todos")
            {
                sql += sqladd + "`ativo` = @ativo";
                sqladd = " AND ";
            }

            sql += sqladd + @"(`cnpj` like CONCAT('%',@busca,'%') 
            OR `razao` like CONCAT('%',@busca,'%') OR
            `nome` like CONCAT('%',@busca,'%'))";

            Empresa con = new Empresa();

            con.NewCMD(sql, CommandType.Text);
            con.AddPar("busca", busca);
            con.AddPar("ativo", ativo);

            return con.TableToCustomers(con.GetTable());
        }

        public bool Inserir()
        {
            if (this.Address.Insert())
            {
                string sql = @"INSERT INTO `empresa` (`cnpj`,`ie`,`razao`,`nome`,`regime`,`contador`,`address`,
                `email`,`telefone`,`observacao`) VALUES (@cnpj,@ie,@razao,@nome,@regime,@contador,@address,
                @email,@telefone,@observacao)";
                NewCMD(sql, CommandType.Text);
                AddPar("cnpj", this.CNPJ);
                AddPar("ie", this.IE);
                AddPar("razao", this.Razao);
                AddPar("nome", this.Nome);
                AddPar("regime", this.Regime);
                AddPar("contador", this.ID_Contador);
                AddPar("address", this.Address.Address_ID);
                AddPar("email", this.Email);
                AddPar("telefone", this.Telefone);
                AddPar("observacao", this.Observacao);
                if (ExeGetId())
                {
                    this.ID = Conexao.lastId;
                    return true;
                }
            }
            return false;
        }

        public bool Atualizar()
        {
            if (this.Address.Update())
            {
                string sql = @"UPDATE `empresa` SET `cnpj` = @cnpj, `ie` = @ie, `razao` = @razao, `nome` = @nome, 
                `regime` = @regime, `contador` = @contador, `address` = @address, `email` = @email, 
                `telefone` = @telefone, `observacao` = @observacao, `ativo` = @ativo WHERE `id` = @id";
                NewCMD(sql, CommandType.Text);
                AddPar("cnpj", this.CNPJ);
                AddPar("ie", this.IE);
                AddPar("razao", this.Razao);
                AddPar("nome", this.Nome);
                AddPar("regime", this.Regime);
                AddPar("contador", this.ID_Contador);
                AddPar("address", this.Address.Address_ID);
                AddPar("email", this.Email);
                AddPar("telefone", this.Telefone);
                AddPar("observacao", this.Observacao);
                AddPar("ativo", this.Ativo);
                AddPar("id", this.ID);

                return ExecuteNQ();
            }
            return false;
        }

        public bool AtivarDesativar()
        {
            string sql = "UPDATE `empresa` SET `ativo` = @ativo WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("ativo", !this.Ativo);
            AddPar("id", this.ID);
            if (ExecuteNQ())
            {
                this.Ativo = !this.Ativo;
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Empresa> TableToCustomers(DataTable table)
        {
            List<Empresa> customers = new List<Empresa>();
            if (table != null)
            {
                customers = (from DataRow dr in table.Rows select new Empresa()
                {
                    ID = Convert.ToInt64(dr["id"]),
                    CNPJ = dr["cnpj"].ToString(),
                    IE = dr["ie"].ToString(),
                    Razao = dr["razao"].ToString(),
                    Nome = dr["nome"].ToString(),
                    Regime = dr["regime"].ToString(),
                    ID_Contador = Convert.ToInt64(dr["contador"]),
                    Address = Address.SearchByID(Convert.ToInt64(dr["address"])),
                    Email = dr["email"].ToString(),
                    Telefone = dr["telefone"].ToString(),
                    Observacao = dr["observacao"].ToString(),
                    Ativo = Convert.ToBoolean(dr["ativo"])
                }).ToList();
                
                return customers;
            }
            return null;
        }
    }
}
