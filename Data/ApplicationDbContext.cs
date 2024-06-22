using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Administrador> Administrador { get; set; }

        public DbSet<Anexo> Anexo { get; set; }


        public DbSet<Comenta> Comenta { get; set; }

        public DbSet<Ficheiro> Ficheiro { get; set; }

        public DbSet<Grupo> Grupo { get; set; }

        public DbSet<Partilha> Partilha { get; set; }

        public DbSet<PartilhaGrupo> PartilhaGrupo { get; set; }


        public DbSet<PedeAcesso> PedeAcesso { get; set; }

        public DbSet<Pertence> Pertence { get; set; }

        public DbSet<Post> Post { get; set; }

        public DbSet<Utilizador_Autenticado> Utilizador_Autenticado {  get; set; } 

    }
}