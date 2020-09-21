using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data.Types;

namespace Agenda_OS
{
    public class Conexao
    {
        private MySqlCommand cmd { get; set; }
        private MySqlConnection con { get; set; }
        private string server { get; set; }
        private string nomebd { get; set; }
        private string usuariobd { get; set; }
        private string senhabd { get; set; }
        private string porta { get; set; }
        private string charset { get; set; }
        private string conLine { get; set; }
        public static string msg { get; set; }
        public static long lastId { get; set; }

        // Define a linha de conexão.
        private void SetConLine()
        {
            this.conLine = "SERVER =" + this.server + ";";
            this.conLine += "DATABASE =" + this.nomebd + ";";
            this.conLine += "UID =" + this.usuariobd + ";";
            this.conLine += "PASSWORD =" + this.senhabd + ";";
            this.conLine += "PORT =" + this.porta + ";";
            this.conLine += "CHARSET =" + this.charset + ";";
        }

        // Conexão com os parametros do App.config.
        protected void inicio()
        {
            this.server = Properties.Settings.Default.server;
            this.nomebd = Properties.Settings.Default.nomebd;
            this.usuariobd = Properties.Settings.Default.usuariobd;
            this.senhabd = Properties.Settings.Default.senhabd;
            this.porta = Properties.Settings.Default.porta;
            this.charset = "utf8";
            SetConLine();
        }

        // Abre a conexao.
        private MySqlConnection Con()
        {
            inicio();
            if (this.con == null)
            {
                this.con = new MySqlConnection(conLine);
            }
            this.con.Open();
            return this.con;
        }

        // Testa a conexao.
        public static bool TestarConexao()
        {
            try
            {
                Conexao conexao = new Conexao();
                MySqlConnection con = conexao.Con();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return false;
            }
        }

        // Executa comando sem retorno.
        protected bool ExecuteNQ()
        {
            try
            {
                this.cmd.Connection = Con();
                this.cmd.ExecuteNonQuery();
                this.con.Close();
                return true;
            }
            catch (Exception e)
            {
                this.con.Close();
                msg = e.Message;
                return false;
            }
        }

        // Executa comando e retorna ultimo id.
        protected bool ExeGetId()
        {
            try
            {
                this.cmd.Connection = Con();
                this.cmd.ExecuteNonQuery();
                Conexao.lastId = this.cmd.LastInsertedId;
                this.con.Close();
                return true;
            }
            catch (Exception e)
            {
                this.con.Close();
                msg = e.Message;
                return false;
            }
        }

        // Executa comando.
        protected bool ExecuteGetBool(string campo)
        {
            try
            {
                this.cmd.Connection = Con();
                MySqlDataReader data = this.cmd.ExecuteReader();
                this.con.Close();
                return data.GetBoolean(campo);
            }
            catch (Exception e)
            {
                this.con.Close();
                msg = e.Message;
                return false;
            }
        }

        // Metodo retorna uma tabela.
        protected DataTable GetTable()
        {
            DataTable table = new DataTable();
            try
            {
                this.cmd.Connection = Con();
                MySqlDataAdapter dta = new MySqlDataAdapter(this.cmd);
                dta.Fill(table);
                this.con.Close();
                return table;
            }
            catch (Exception e)
            {
                this.con.Close();
                msg = e.Message;
                return null;
            }
        }



        // Cria comando MySQL.
        protected void NewCMD(string sql, CommandType cmdType)
        {
            this.cmd = new MySqlCommand(sql);
            this.cmd.CommandType = cmdType;
        }

        // Adiciona um parametro ao comando.
        protected void AddPar(string par, object val)
        {
            this.cmd.Parameters.AddWithValue(par, val);
        }
    }
}
