using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public class EstudanteDbContext : DbContext
    {
        public EstudanteDbContext(DbContextOptions<EstudanteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
