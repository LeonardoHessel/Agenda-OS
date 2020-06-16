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
        public long ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public DateTime Nasc { get; set; }
        public string Sexo { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }

        

        public bool SalvarUsuario(string action)
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
            string sql = "INSERT INTO `usuario` (`login`,`senha`,`nome`,`nasc`,`sexo`,`rg`,`cpf`,`cnh`) VALUES(@login,@senha,@nome,@nasc,@sexo,@rg,@cpf,@cnh)";
            NewCMD(sql, CommandType.Text);
            AddPar("login", this.Login);
            AddPar("senha", this.Senha);
            AddPar("nome", this.Nome);
            AddPar("nasc", this.Nasc);
            AddPar("sexo", this.Sexo);
            AddPar("rg", this.RG);
            AddPar("cpf", this.CPF);
            AddPar("cnh", this.CNH);
            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                return true;
            }
            return false;
        }

        private bool Atualizar()
        {
            string sql = "UPDATE `usuario` SET `login`= @login, `senha`= @senha, `nome`= @nome,`nasc`= @nasc,`sexo`= @sexo,`rg`= @rg,`cpf`= @cpf,`cnh`= @cnh WHERE `id`= @id";
            NewCMD(sql, CommandType.Text);
            AddPar("id", this.ID);
            AddPar("login", this.Login);
            AddPar("senha", this.Senha);
            AddPar("nome", this.Nome);
            AddPar("nasc", this.Nasc);
            AddPar("sexo", this.Sexo);
            AddPar("rg", this.RG);
            AddPar("cpf", this.CPF);
            AddPar("cnh", this.CNH);
            if (ExecuteNQ())
            {
                return true;
            }
            return false;
        }

        public static List<Usuario> BuscarUsuarios(string busca, bool deletados)
        {
            /*
                SELECT * FROM `usuario` WHERE `login` like CONCAT('%','leo','%') OR 
                `login` like CONCAT('%','leo','%') OR `nome` like CONCAT('%','leo','%') OR
                `nasc` like CONCAT('%','leo','%') OR `sexo` like CONCAT('%','leo','%') OR
                `rg` like CONCAT('%','leo','%') OR `cpf` like CONCAT('%','leo','%') OR
                `cnh` like CONCAT('%','leo','%') AND `del` = true;
            */
            string sql = "SELECT * FROM `usuario` WHERE `login` like CONCAT('%',@busca,'%') OR " +
                "`login` like CONCAT('%',@busca,'%') OR `nome` like CONCAT('%',@busca,'%') OR" +
                "`nasc` like CONCAT('%',@busca,'%') OR `sexo` like CONCAT('%',@busca,'%') OR" +
                "`rg` like CONCAT('%',@busca,'%') OR `cpf` like CONCAT('%',@busca,'%') OR" +
                "`cnh` like CONCAT('%',@busca,'%')";
            Usuario usuario = new Usuario();
            usuario.NewCMD(sql, CommandType.Text);
            usuario.AddPar("busca", busca);
            //usuario.AddPar("del", deletados);
            DataTable table = usuario.GetTable();
            List<Usuario> listaUsuario = new List<Usuario>();
            if (table != null)
            {
                listaUsuario = (from DataRow dr in table.Rows select new Usuario() {
                    ID = Convert.ToInt64(dr["id"]),
                    Login = dr["login"].ToString(),
                    Senha = dr["senha"].ToString(),
                    Nome = dr["nome"].ToString(),
                    Nasc = DateTime.Parse(dr["nasc"].ToString()),
                    Sexo = dr["sexo"].ToString(),
                    RG = dr["rg"].ToString(),
                    CPF = dr["cpf"].ToString(),
                    CNH = dr["cnh"].ToString()
                }).ToList();
                return listaUsuario;
            }
            return null;
        }
    }
}
