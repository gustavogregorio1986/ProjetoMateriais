using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class AdministradorMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Administrador>(adm =>
            {
                adm.ToTable("Administrador");
                adm.HasKey(a => a.IdAdministrador).HasName("IdAdm").IsClustered();
                adm.Property(a => a.NomeAdm).HasColumnName("NomeAdm").IsRequired();
                adm.Property(a => a.EmailAdm).HasColumnName("EmailAdm").IsRequired();
                adm.HasOne(a => a.Usuario).WithOne(u => u.Administrador);
            });
        }
    }
}
