using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string EmailCliente { get; set; }

        public string Sexo { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual Protocolo Protocolo { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Cliente()
        {

        }

        public Cliente(int IdCliente, string NomeCliente, string EmailCliente, string Sexo)
        {
            this.IdCliente = IdCliente;
            this.NomeCliente = NomeCliente;
            this.EmailCliente = EmailCliente;
            this.Sexo = Sexo;
        }
    }
}
