using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_gamer_com_back_e_sql.Models;

namespace Projeto_gamer_com_back_e_sql.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = NOTE22-S15; initial catalog = gamerTarde; User Id=sa; pwd=Senai@134; TrustServerCertificate = True");
            }
        }

        public DbSet<Jogador> Jogador {get; set; }

        public DbSet<Equipe> Equipe {get; set; }
    }
}