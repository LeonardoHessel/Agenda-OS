using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_OS
{
    public class OrdemServico:Conexao
    {
        public long ID { get; set; }
        // public string Categoria { get; set; }
        public long ID_Cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public string Solicitante { get; set; }
        public long ID_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public string Solucao { get; set; }
        public long ID_Produto { get; set; }
        public string Atendimento { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public string Situacao { get; set; }
        //public bool Deletado { get; set; }

        public string MSG { get; set; }

        public bool Inserir()
        {
            string sql = @"INSERT INTO `OS` (
            `empresa`,`solicitante`,`usuario`,`assunto`,`descricao`,`solucao`,`produto`,
            `atendimento`,`abertura`,`fechamento`,`situacao`
            ) VALUES (
            @id_cliente,@solicitante,@id_usuario,@assunto,@descricao,@solucao,@id_produto,
            @atendimento,@abertura,@fechamento,@situacao
            )";
            NewCMD(sql, CommandType.Text);
            AddPar("id_cliente", ID_Cliente);
            AddPar("solicitante", Solicitante);
            AddPar("id_usuario", ID_Usuario);
            AddPar("assunto", Assunto);
            AddPar("descricao", Descricao);
            AddPar("solucao", Solucao);
            AddPar("id_produto", ID_Produto);
            AddPar("atendimento", Atendimento);
            AddPar("abertura", Abertura);
            AddPar("fechamento", Fechamento);
            AddPar("situacao", Situacao);
            if (ExeGetId())
            {
                this.ID = lastId;
                return true;
            }
            else
            {
                this.MSG = msg;
                return false;
            }
        }

        public bool Atualizar()
        {
            string sql = @"UPDATE `OS` 
            SET 
            `empresa` = @id_cliente,
            `solicitante` = @solicitante,
            `usuario` = @id_usuario,
            `assunto` = @assunto,
            `descricao` = @descricao,
            `solucao` = @solucao,
            `produto` = @id_produto,
            `atendimento` = @atendimento,
            `abertura` = @abertura,
            `fechamento` = @fechamento,
            `situacao` = @situacao
            WHERE 
            `id` = @id";
            NewCMD(sql, CommandType.Text);
            AddPar("id_cliente", ID_Cliente);
            AddPar("solicitante", Solicitante);
            AddPar("id_usuario", ID_Usuario);
            AddPar("assunto", Assunto);
            AddPar("descricao", Descricao);
            AddPar("solucao", Solucao);
            AddPar("id_produto", ID_Produto);
            AddPar("atendimento", Atendimento);
            AddPar("abertura", Abertura);
            AddPar("fechamento", Fechamento);
            AddPar("situacao", Situacao);
            AddPar("id", ID);
            if (ExecuteNQ())
            {
                return true;
            }
            else
            {
                this.MSG = msg;
                return false;
            }
        }

        public static List<OrdemServico> TodasOrdenServico(string busca)
        {
            string sql;
            OrdemServico Con = new OrdemServico();
            sql = @"SELECT `os`.*, `e`.`nome` AS `nome_empresa`, `u`.`nome` AS `nome_usuario` FROM `os` 
            JOIN `empresa` AS `e` 
            JOIN `usuario` as `u` 
            ON `e`.`id` = `os`.`empresa` 
            AND `u`.`id` = `os`.`usuario` 
            WHERE `os`.`id` like CONCAT('%', @busca, '%') 
            OR `empresa` like CONCAT('%', @busca, '%')
            OR `solicitante` like CONCAT('%', @busca, '%')
            OR `assunto` like CONCAT('%', @busca, '%')
            OR `descricao` like CONCAT('%', @busca, '%')
            OR `solucao` like CONCAT('%', @busca, '%')
            OR `e`.`nome` like CONCAT('%', @busca, '%')
            OR `u`.`nome` like CONCAT('%', @busca, '%')
            ";
            Con.NewCMD(sql, CommandType.Text);
            Con.AddPar("busca", busca);
            DataTable tabela = Con.GetTable();
            List<OrdemServico> os = new List<OrdemServico>();
            if (tabela != null)
            {
                os = (from DataRow row in tabela.Rows select new OrdemServico()
                {
                    ID = Convert.ToInt64(row["id"]),
                    ID_Cliente = Convert.ToInt64(row["empresa"]),
                    Nome_Cliente = row["nome_empresa"].ToString(),
                    Solicitante = row["solicitante"].ToString(),
                    ID_Usuario = Convert.ToInt64(row["usuario"]),
                    Nome_Usuario = row["nome_usuario"].ToString(),
                    Assunto = row["assunto"].ToString(),
                    Descricao = row["descricao"].ToString(),
                    Solucao = row["solucao"].ToString(),
                    ID_Produto = Convert.ToInt64(row["produto"]),
                    Atendimento = row["atendimento"].ToString(),
                    Abertura = DateTime.Parse(row["abertura"].ToString()),
                    Fechamento = DateTime.Parse(row["fechamento"].ToString()),
                    Situacao = row["situacao"].ToString(),
                }).ToList();
                return os;
            }
            return null;
        }
    }
}
