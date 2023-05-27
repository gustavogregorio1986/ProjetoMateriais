using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Administrador
    {
        public int IdAdministrador { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }


        public Usuario Usuario { get; set; }

        public Administrador()
        {

        }

        public Administrador(int IdAdministrador, string NomeAdm, string EmailAdm)
        {
            this.IdAdministrador = IdAdministrador;
            this.NomeAdm = NomeAdm;
            this.EmailAdm = EmailAdm;
        }

        public override string ToString()
        {
            return IdAdministrador + "," + NomeAdm + "," + EmailAdm;
        }
    }
}
