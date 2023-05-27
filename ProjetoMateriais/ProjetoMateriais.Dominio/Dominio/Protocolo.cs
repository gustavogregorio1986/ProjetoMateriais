using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Protocolo
    {
        public int IdProtocolo { get; set; }

        public string NomeProtocolo { get; set; }

        public string SerieProtocolo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public virtual Pagamento Pagamento { get; set; }

        public Material Material { get; set; }

        public Protocolo()
        {

        }

        public Protocolo(int IdProtocolo, string NomeProtocolo, string SerieProtocolo, DateTime DataInicio, DateTime DataFim)
        {
            this.IdProtocolo = IdProtocolo;
            this.NomeProtocolo = NomeProtocolo;
            this.SerieProtocolo = SerieProtocolo;
            this.DataInicio = DataInicio;
            this.DataFim = DataFim;
        }

        public override string ToString()
        {
            return IdProtocolo + "," + NomeProtocolo + "," + SerieProtocolo + "," + DataInicio + "," + DataFim;
        }
    }
}
