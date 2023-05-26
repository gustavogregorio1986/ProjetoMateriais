using Microsoft.EntityFrameworkCore;
using ProjetoMateriais.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMateriais.Data.Contexto
{
    public class ProjetoMateriaisContexto : DbContext
    {
        public ProjetoMateriaisContexto()
        {

        }

        public ProjetoMateriaisContexto(DbContextOptions<ProjetoMateriaisContexto> options)
            : base(options)
        {

        }

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Material> Materiais { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public DbSet<Protocolo> Protocolos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
