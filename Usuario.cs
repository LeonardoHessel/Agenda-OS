using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Usuario:Conexao
    {
        public long id { get; set; }
        public string nome { get; set; }
        public DateTime nasc { get; set; }
        public string sexo { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string cnh { get; set; }

        

        public bool SalvarTec(string action)
        {
            
            if (action == "New")
            {
                return Cadastrar();
            }
            else if (action == "Edit")
            {
                return Atualizar();
            }
            return false;
        }

        private bool Cadastrar()
        {
            string sql = "INSERT INTO `usuario` (`nome`,`nasc`,`sexo`,`rg`,`cpf`,`cnh`) VALUES(@nome,@nasc,@sexo,@rg,@cpf,@cnh)";
            NewCMD(sql, CommandType.Text);
            AddPar("nome", this.nome);
            AddPar("nasc", this.nasc);
            AddPar("sexo", this.sexo);
            AddPar("rg", this.rg);
            AddPar("cpf", this.cpf);
            AddPar("cnh", this.cnh);
            if (ExeGetId())
            {
                this.id = Conexao.lastId;
                return true;
            }
            return false;
        }

        private bool Atualizar()
        {
            string sql = "UPDATE `usuario` SET `nome`=@nome,`nasc`=@nasc,`sexo`=@sexo,`rg`=@rg,`cpf`=@cpf,`cnh`=@cnh WHERE `id`=@id";
            NewCMD(sql, CommandType.Text);
            AddPar("id", this.id);
            AddPar("nome", this.nome);
            AddPar("nasc", this.nasc);
            AddPar("sexo", this.sexo);
            AddPar("rg", this.rg);
            AddPar("cpf", this.cpf);
            AddPar("cnh", this.cnh);
            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }

        public static List<Usuario> TabelaTodosTecnico()
        {
            string sql = "SELECT * FROM `usuario`";
            Usuario tecnicos = new Usuario();
            tecnicos.NewCMD(sql, CommandType.Text);

            DataTable table = tecnicos.GetTable();

            List<Usuario> listaTecnico = new List<Usuario>();
            if (table != null)
            {
                listaTecnico = (from DataRow dr in table.Rows select new Usuario() {
                    id = Convert.ToInt64(dr["id"]),
                    nome = dr["nome"].ToString(),
                    nasc = DateTime.Parse(dr["nasc"].ToString()),
                    sexo = dr["sexo"].ToString(),
                    rg = dr["rg"].ToString(),
                    cpf = dr["cpf"].ToString(),
                    cnh = dr["cnh"].ToString()
                }).ToList();
                return listaTecnico;
            }
            return null;
        }
    }
}
