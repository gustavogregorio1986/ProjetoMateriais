using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class ProtocoloMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Protocolo>(protocolo =>
            {
                protocolo.ToTable("Protocolo");
                protocolo.HasKey(pro => pro.IdProtocolo).HasName("IdProtocolo").IsClustered();
                protocolo.Property(pro => pro.NomeProtocolo).HasColumnName("NomeProtocolo").IsRequired();
                protocolo.Property(pro => pro.DataInicio).HasColumnName("DataInicio").IsRequired();
                protocolo.Property(pro => pro.DataFim).HasColumnName("DataFim").IsRequired();
                protocolo.HasOne(pro => pro.Pagamento).WithOne(pa => pa.Protocolo);
            });
        }
    }
}
