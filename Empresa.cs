using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Empresa:Conexao
    {
        // Customer
        public long ID;
        public string CNPJ;
        public string IE;
        public string Razao;
        public string Nome;
        public string Email;
        public string Telefone;
        public string Observacao;
        // Address
        public Address Address;
        //// Accountant
        //public string AccountantName;
        //public string AccountantEmail;
        //// Product
        //public Produto Product;
        //public string ProductModule;
        // Status
        public bool Ativo;

        // ---------- ---------- ---------- ---------- ---------- //

        private void AddParameters(string mode)
        {
            if (mode != "Insert")
                AddPar("id", this.ID);

            AddPar("cnpj", this.CNPJ);
            AddPar("ie", this.IE);
            AddPar("razao", this.Razao);
            AddPar("nome", this.Nome);
            AddPar("email", this.Email);
            AddPar("telefone", this.Telefone);
            AddPar("observacao", this.Observacao);
            AddPar("address", this.Address.Address_ID);
            //AddPar("accountantname", this.AccountantName);
            //AddPar("accountantemail", this.AccountantEmail);

            //if (this.Product is Produto)
            //    AddPar("product", this.Product.ID);
            //else
            //    AddPar("product", null);

            //AddPar("productmodule", this.ProductModule);

            if (mode != "Insert")
                AddPar("ativo", this.Ativo);
        }

        private List<Empresa> TableToList(DataTable table)
        {
            List<Empresa> customers = new List<Empresa>();
            if (table != null)
            {
                customers = (from DataRow row in table.Rows
                             select new Empresa()
                             {
                                 ID = Convert.ToInt64(row["id"]),
                                 CNPJ = row["cnpj"].ToString(),
                                 IE = row["ie"].ToString(),
                                 Razao = row["razao"].ToString(),
                                 Nome = row["nome"].ToString(),
                                 Email = row["email"].ToString(),
                                 Telefone = row["telefone"].ToString(),
                                 Observacao = row["observacao"].ToString(),
                                 Address = row["address"] is DBNull ? null : Address.SearchByID(Convert.ToInt64(row["address"])),
                                 //AccountantName = row["accountantname"].ToString(),
                                 //AccountantEmail = row["accountantemail"].ToString(),
                                 //Product = row["product"] is DBNull ? null : Produto.GetProductByID(Convert.ToInt64(row["product"])),
                                 //ProductModule = row["productmodule"].ToString(),
                                 Ativo = Convert.ToBoolean(row["ativo"]),
                             }).ToList();

                return customers;
            }
            return null;
        }

        // ---------- ---------- ---------- ---------- ---------- //

        public bool Insert()
        {
            if (this.Address.Insert())
            {
                string sql = @"INSERT INTO `customer` 
                (`cnpj`,`ie`,`razao`,`nome`,`address`,`email`,`telefone`,`observacao`,
                `accountantname`,`accountantemail`,`product`,`productmodule`)
                VALUES (@cnpj,@ie,@razao,@nome,@address,@email,@telefone,@observacao,
                `accountantname`,`accountantemail`,`product`,`productmodule`)";

                NewCMD(sql, CommandType.Text);
                AddParameters("Insert");
                
                if (ExeGetId())
                {
                    this.ID = Conexao.lastId;
                    this.Ativo = true;
                    return true;
                }
            }
            return false;
        }

        public static Empresa GetCustomerByID(long empresaId)
        {
            Empresa con = new Empresa();
            string sql = @"SELECT * FROM `customer` WHERE `id` = @id";
            con.NewCMD(sql, CommandType.Text);
            con.AddPar("id", empresaId);
            return con.TableToList(con.GetTable())[0];
        }

        public static List<Empresa> SearchCustomer()
        {
            Empresa empresa = new Empresa();
            empresa.ID = 20;
            empresa.Razao = "Teste";
            empresa.Nome = "Teste";
            empresa.Email = "Teste";
            empresa.Telefone = "Teste";
            empresa.Observacao = "Teste";

            List<Empresa> empresas = new List<Empresa>();
            empresas.Add(empresa);

            return empresas;

            ////bool ativo = false;
            ////if (status == "Ativos")
            ////    ativo = true;

            ////string sqladd = " WHERE ";
            //string sql = "SELECT * FROM `customer`";

            ////if (status != "Todos")
            ////{
            ////    sql += sqladd + "`ativo` = @ativo";
            ////    sqladd = " AND ";
            ////}

            ////sql += sqladd + @"(`cnpj` like CONCAT('%',@busca,'%') 
            ////OR `razao` like CONCAT('%',@busca,'%') OR
            ////`nome` like CONCAT('%',@busca,'%'))";

            //Empresa con = new Empresa();

            //con.NewCMD(sql, CommandType.Text);
            ////con.AddPar("busca", busca);
            ////con.AddPar("ativo", ativo);

            //return con.TableToList(con.GetTable());
        }

        public bool Update()
        {
            if (this.Address.Update())
            {
                string sql = @"UPDATE `customer` 
                SET `cnpj` = @cnpj, `ie` = @ie, `razao` = @razao, `nome` = @nome, `email` = @email, 
                `telefone` = @telefone, `observacao` = @observacao, `address` = @address
                `accountantname` = @accountantname, `accountantemail` = @accountantemail, 
                `product` = @product, `productmodule` = @productmodule, `ativo` = @ativo WHERE `id` = @id";
                
                NewCMD(sql, CommandType.Text);
                AddParameters("Update");

                return ExecuteNQ();
            }
            return false;
        }
    }
}
