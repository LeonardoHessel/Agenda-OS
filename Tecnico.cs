using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public bool SalvarTec()
        {
            CMD("AddOrEditTecnico", CommandType.StoredProcedure);
            AddPar("codTecnico", this.codigo);
            AddPar("nome", this.nome);
            AddPar("nome", this.nome);
            AddPar("nasc", this.nasc);
            AddPar("sexo", this.sexo);
            AddPar("rg", this.rg);
            AddPar("cpf", this.cpf);
            AddPar("cnh", this.cnh);
            long rtnId;
            if (this.codigo < 1)
            {
                rtnId = ExeGetId();
                this.codigo = rtnId;
                return true;
            }
            else
            {
                ExecuteNQ();
                return true;
            }
            return false;
        }
    }
}
