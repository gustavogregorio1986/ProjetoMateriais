using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Endereco
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Cep { get; set; }

        public Cliente Cliente { get; set; }

        public Endereco()
        {

        }

        public Endereco(int IdEndereco, string Logradouro, string Bairro, string Ciadde, string Uf, string Cep)
        {
            this.IdEndereco = IdEndereco;
            this.Logradouro = Logradouro;
            this.Bairro = Bairro;
            this.Ciadde = Ciadde;
            this.Uf = Uf;
            this.Cep = Cep;
        }
    }
}
