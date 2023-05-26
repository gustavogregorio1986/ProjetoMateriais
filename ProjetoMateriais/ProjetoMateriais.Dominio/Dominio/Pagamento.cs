using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Qtde { get; set; }

        public Protocolo Protocolo { get; set; }

        public Pagamento()
        {

        }

        public Pagamento(int IdPagamento, decimal Preco, int Qtde)
        {
            this.IdPagamento = IdPagamento;
            this.Preco = Preco;
            this.Qtde = Qtde;
        }
    }
}
