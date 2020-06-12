using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class Tecnico:Conexao
    {
        public long codigo { get; set; }
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
            string sql = "INSERT INTO `tecnico` VALUES(0,@_nome,@_nasc,@_sexo,@_rg,@_cpf,@_cnh)";
            NewCMD(sql, CommandType.Text);
            AddPar("_nome", this.nome);
            AddPar("_nasc", this.nasc);
            AddPar("_sexo", this.sexo);
            AddPar("_rg", this.rg);
            AddPar("_cpf", this.cpf);
            AddPar("_cnh", this.cnh);
            if (ExeGetId())
            {
                this.codigo = Conexao.lastId;
                return true;
            }
            return false;
        }

        private bool Atualizar()
        {
            string sql = "UPDATE `tecnico` SET `nome`=@_nome,`nasc`=@_nasc,`sexo`=@_sexo,`rg`=@_rg,`cpf`=@_cpf,`cnh`=@_cnh WHERE `codTecnico`=@_id";
            NewCMD(sql, CommandType.Text);
            AddPar("_id", this.codigo);
            AddPar("_nome", this.nome);
            AddPar("_nasc", this.nasc);
            AddPar("_sexo", this.sexo);
            AddPar("_rg", this.rg);
            AddPar("_cpf", this.cpf);
            AddPar("_cnh", this.cnh);
            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }

        public static List<Tecnico> TabelaTodosTecnico()
        {
            string sql = "SELECT * FROM `tecnico`";
            Tecnico tecnicos = new Tecnico();
            tecnicos.NewCMD(sql, CommandType.Text);
            DataTable table = tecnicos.GetTable();
            List<Tecnico> listaTecnico = new List<Tecnico>();
            if (table != null)
            {
                listaTecnico = (from DataRow dr in table.Rows
                                select new Tecnico()
                                {
                                    codigo = Convert.ToInt64(dr["codTecnico"]),
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
