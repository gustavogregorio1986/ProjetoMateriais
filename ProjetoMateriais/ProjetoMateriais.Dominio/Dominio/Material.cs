using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Material
    {
        public int IdMaterial { get; set; }

        public string Nomematerial { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Descricao { get; set; }

        public virtual Protocolo Protocolo { get; set; }

        public Material()
        {

        }

        public Material(int IdMaterial, string Nomematerial, DateTime DataCadastro, string Descricao)
        {
            this.IdMaterial = IdMaterial;
            this.Nomematerial = Nomematerial;
            this.DataCadastro = DataCadastro;
            this.Descricao = Descricao;
        }
    }
}
