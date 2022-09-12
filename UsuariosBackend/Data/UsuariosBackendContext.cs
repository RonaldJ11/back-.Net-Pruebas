using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsuariosBackend.Models;

namespace UsuariosBackend.Data
{
    public class UsuariosBackendContext : DbContext
    {
        public UsuariosBackendContext (DbContextOptions<UsuariosBackendContext> options)
            : base(options)
        {
        }

        public DbSet<UsuariosBackend.Models.User> User { get; set; } = default!;
    }
}
