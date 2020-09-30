using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Agenda_OS
{
    public class Address:Conexao
    {
        public long Address_ID;
        public string CEP;
        public string UF;
        public string City;
        public string IBGE;
        public string District;
        public string Street;
        public string Number;
        public string Obs;
        public bool Active;

        public static Address AddressRequest(string CEP)
        {
            // Realização da requisição do endereço

            return null;
        }

        public bool Insert()
        {
            string sql = @"INSERT INTO `address` (cep, uf, city, ibge, district, street, number, obs) 
            Values (@cep, @uf, @city, @ibge, @district, @street, @number, @obs)";
            NewCMD(sql, CommandType.Text);
            AddPar("cep", this.CEP);
            AddPar("uf", this.UF);
            AddPar("city", this.City);
            AddPar("ibge", this.IBGE);
            AddPar("district", this.District);
            AddPar("street", this.Street);
            AddPar("number", this.Number);
            AddPar("obs", this.Obs);

            if (ExeGetId())
            {
                this.Address_ID = Conexao.lastId;
                this.Active = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Address SearchByID(long address_id)
        {
            Address con = new Address();
            string sql = "SELECT * FROM address WHERE `id` = @id";
            con.NewCMD(sql, CommandType.Text);
            con.AddPar("id", address_id);

            List<Address> addresses = new List<Address>();

            DataTable table = con.GetTable();
            if (table != null)
            {
                addresses = (from DataRow rows in table.Rows
                             select new Address()
                             {
                                 Address_ID = Convert.ToInt64(rows["id"]),
                                 CEP = rows["cep"].ToString(),
                                 UF = rows["uf"].ToString(),
                                 City = rows["city"].ToString(),
                                 IBGE = rows["ibge"].ToString(),
                                 District = rows["district"].ToString(),
                                 Street = rows["street"].ToString(),
                                 Number = rows["number"].ToString(),
                                 Obs = rows["obs"].ToString(),
                             }).ToList();
                return addresses[0];
            }
            return null;
        }

        public bool Update()
        {
            string sql = @"UPDATE `address` SET `cep` = @cep, `uf` = @uf, `city` = @city, `ibge` = @ibge,
            `district` = @district, `street` = @street, `number` = @number, `obs` = @obs WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("cep", this.CEP);
            AddPar("uf", this.UF);
            AddPar("city", this.City);
            AddPar("ibge", this.IBGE);
            AddPar("district", this.District);
            AddPar("street", this.Street);
            AddPar("number", this.Number);
            AddPar("obs", this.Obs);
            AddPar("id", this.Address_ID);

            return ExecuteNQ();
        }

        public bool Deactivate()
        {
            string sql = "UPDATE `address` SET `active` = @active WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("active", false);
            AddPar("id", this.Address_ID);

            if (ExecuteNQ())
            {
                this.Active = false;
                return true;
            }
            return false;
        }

        public bool Activate()
        {
            string sql = "UPDATE `address` SET `active` = @active WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("active", true);
            AddPar("id", this.Address_ID);

            if (ExecuteNQ())
            {
                this.Active = true;
                return true;
            }
            return false;
        }

        public bool Delete()
        {
            string sql = "DELETE FROM `address` wHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("active", false);
            AddPar("id", this.Address_ID);

            return ExecuteNQ();
        }
    }
}
