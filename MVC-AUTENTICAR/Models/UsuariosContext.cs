using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_AUTENTICAR.Models
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext() : base("Usuarios")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
}  
}