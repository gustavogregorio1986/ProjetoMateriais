using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class MaterialMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Material>(mat =>
            {
                mat.ToTable("Material");
                mat.HasKey(m => m.IdMaterial).HasName("IdMaterial").IsClustered();
                mat.Property(m => m.Nomematerial).HasColumnName("Nomematerial").IsRequired();
                mat.Property(m => m.Descricao).HasColumnName("Descricao").IsRequired();
                mat.Property(m => m.DataCadastro).HasColumnName("DataCadastro").IsRequired();
                mat.HasOne(m => m.Protocolo).WithOne(p => p.Material);
            });
        }
    }
}
