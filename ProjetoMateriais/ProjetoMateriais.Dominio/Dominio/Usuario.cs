using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Dominio.Dominio
{
    public class Usuario
    {
        public int IdUser { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }

        public virtual Administrador Administrador { get; set; }

        public virtual Cliente Cliente { get; set; }

        public Usuario()
        {

        }

        public Usuario(int IdUser, string Login, string Senha, string Perfil)
        {
            this.IdUser = IdUser;
            this.Login = Login;
            this.Senha = Senha;
            this.Perfil = Perfil;
        }
    }
}
