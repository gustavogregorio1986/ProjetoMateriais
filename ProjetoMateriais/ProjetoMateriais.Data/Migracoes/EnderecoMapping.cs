using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class EnderecoMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Endereco>(end =>
            {
                end.ToTable("Endereco");
                end.HasKey(e => e.IdEndereco).HasName("IdEndereco").IsClustered();
                end.Property(e => e.Logradouro).HasColumnName("Logradouro").IsRequired();
                end.Property(e => e.Bairro).HasColumnName("Bairro").IsRequired();
                end.Property(e => e.Cidade).HasColumnName("Cidade").IsRequired();
                end.Property(e => e.Uf).HasColumnName("Uf").IsRequired();
                end.Property(e => e.Cep).HasColumnName("Cep").IsRequired();
                end.HasOne(e => e.Cliente).WithOne(c => c.Endereco);
            });
        }
    }
}
