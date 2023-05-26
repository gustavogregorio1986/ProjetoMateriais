using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Migracoes
{
    public class PagamentoMapping
    {
        public void ConfiguraCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Pagamento>(paga =>
            {
                paga.ToTable("Pagamento");
                paga.HasKey(pag => pag.IdPagamento).HasName("IdPagamento").IsClustered();
                paga.Property(pag => pag.Preco).HasColumnName("Preco").IsRequired();
                paga.Property(pag => pag.Qtde).HasColumnName("Qtde").IsRequired();
            });
        }
    }
}
