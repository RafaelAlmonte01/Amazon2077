using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon2077.Areas.Usuarios.Models
{
    public partial class dbUsuarioContext : DbContext
    {
        public dbUsuarioContext()
        {
        }

        public dbUsuarioContext(DbContextOptions<dbUsuarioContext> options)
            : base(options)
        {
        }

        public DbSet<InputModelRegister> Usuarios { get; set; }

    }
}
