using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class UsuarioMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Usuario>(usu =>
            {
                usu.ToTable("Usuario");
                usu.HasKey(u => u.IdUser).HasName("IdUser").IsClustered();
                usu.Property(u => u.Login).HasColumnName("Login").IsRequired();
                usu.Property(u => u.Senha).HasColumnName("Senha").IsRequired();
                usu.Property(u => u.Perfil).HasColumnName("Perfil").IsRequired();
            });
        }
    }
}
