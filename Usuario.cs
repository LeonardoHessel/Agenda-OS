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
        public string PerfilIMG { get; set; }
        public List<Permissao> Permissoes { get; set; }

        public bool Ativo;
        
        public int VerificarLogin()
        {
            string sql = "SELECT * FROM `usuario` WHERE `login`= @login";
            NewCMD(sql, CommandType.Text);
            AddPar("login", this.Login);
            DataTable table = GetTable();
            int cadastro = table.Rows.Count;
            return cadastro;
        }

        public bool Inserir()
        {
            string sql = "INSERT INTO `usuario` (`login`,`senha`,`nome`,`nasc`,`sexo`,`rg`,`cpf`,`cnh`,`imgperfil`) VALUES(@login,@senha,@nome,@nasc,@sexo,@rg,@cpf,@cnh,@img)";
            NewCMD(sql, CommandType.Text);
            AddPar("login", this.Login);
            AddPar("senha", this.Senha);
            AddPar("nome", this.Nome);
            AddPar("nasc", this.Nasc);
            AddPar("sexo", this.Sexo);
            AddPar("rg", this.RG);
            AddPar("cpf", this.CPF);
            AddPar("cnh", this.CNH);
            AddPar("img", this.PerfilIMG);
            if (ExeGetId())
            {
                this.ID = Conexao.lastId;
                this.Ativo = true;
                return true;
            }
            return false;
        }

        public bool Atualizar()
        {
            string sql = "UPDATE `usuario` SET `login`= @login, `senha`= @senha, `nome`= @nome,`nasc`= @nasc,`sexo`= @sexo,`rg`= @rg,`cpf`= @cpf,`cnh`= @cnh, `imgperfil`= @img WHERE `id`= @id";
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
            AddPar("img", this.PerfilIMG);
            
            return ExecuteNQ();
        }

        public static List<Usuario> TodosUsuarios(string status = "Ativos", string busca = "", bool addTodos = false)
        {
            string sql;
            Usuario con = new Usuario();
            sql = @"SELECT * FROM `usuario` 
            WHERE (`login` like CONCAT('%',@busca,'%') OR
            `nome` like CONCAT('%',@busca,'%') OR 
            `nasc` like CONCAT('%',@busca,'%') OR 
            `sexo` like CONCAT('%',@busca,'%') OR 
            `rg` like CONCAT('%',@busca,'%') OR 
            `cpf` like CONCAT('%',@busca,'%') OR 
            `cnh` like CONCAT('%',@busca,'%')) 
            ";
            
            if (status != "Todos")
                sql += "AND `ativo` = @ativo";

            con.NewCMD(sql, CommandType.Text);
            con.AddPar("busca", busca);

            if (status == "Ativos")
                con.AddPar("ativo", true);
            else if (status == "Inativos")
                con.AddPar("ativo", false);

            DataTable table = con.GetTable();


            List<Usuario> listaUsuario = new List<Usuario>();
            if (table != null)
            {
                listaUsuario = (from DataRow dr in table.Rows select new Usuario()
                {
                    ID = Convert.ToInt64(dr["id"]),
                    Login = dr["login"].ToString(),
                    Senha = dr["senha"].ToString(),
                    Nome = dr["nome"].ToString(),
                    Nasc = DateTime.Parse(dr["nasc"].ToString()),
                    Sexo = dr["sexo"].ToString(),
                    RG = dr["rg"].ToString(),
                    CPF = dr["cpf"].ToString(),
                    CNH = dr["cnh"].ToString(),
                    PerfilIMG = dr["imgperfil"].ToString(),
                    Ativo = Convert.ToBoolean(dr["ativo"]),
                }).ToList();
                
                if (addTodos)
                {
                    Usuario todos = new Usuario();
                    todos.ID = 0;
                    todos.Nome = "Todos";
                    listaUsuario.Insert(0,todos);
                }
                return listaUsuario;
            }
            return null;
        }


        public void LoadPermissoesUsuario()
        {
            this.Permissoes = Permissao.CarregarPermissoes(this.ID);
        }

        public bool VerifPermissao(long ID_modulo)
        {
            foreach (Permissao permissao in Permissoes)
            {
                if (permissao.ID_Modulo == ID_modulo)
                {
                    return permissao.Acesso;
                }
            }
            return false;
        }

        public bool AlterarStatus()
        {
            string sql = "UPDATE `usuario` SET `ativo` = @status WHERE `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("status", !this.Ativo);
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
    }
}
