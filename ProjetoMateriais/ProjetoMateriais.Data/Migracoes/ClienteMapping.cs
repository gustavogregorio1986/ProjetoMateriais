using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class ClienteMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Cliente>(cli =>
            {
                cli.ToTable("Cliente");
                cli.HasKey(c => c.IdCliente).HasName("IdCliente").IsClustered();
                cli.Property(c => c.NomeCliente).HasColumnName("NomeCliente").IsRequired();
                cli.Property(c => c.EmailCliente).HasColumnName("EmailCliente").IsRequired();
                cli.Property(c => c.Sexo).HasColumnName("Sexo").IsRequired();
                cli.HasOne(c => c.Endereco).WithOne(e => e.Cliente);
                cli.HasOne(c => c.Usuario).WithOne(u => u.Cliente);
            });
        }
    }
}
