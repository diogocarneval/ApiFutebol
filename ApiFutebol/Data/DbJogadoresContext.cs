using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiFutebol.Models;

namespace ApiFutebol.Data
{
    public class DbJogadoresContext : DbContext
    {
        public DbJogadoresContext (DbContextOptions<DbJogadoresContext> options)
            : base(options)
        {
        }

        public DbSet<ApiFutebol.Models.JogadorFutebol> JogadorFutebol { get; set; } = default!;


        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JogadorFutebol>().HasData(
            new JogadorFutebol
            {
                Id = 1,
                Idade = 30,
                NumeroCamisa = 21,
                Nome = "Paulo Dybala",
                Time = "Roma",
                Posicao = "Atacante",
                Nacionalidade = "Argentino",
                Status = "Ativo"
            });
                }
    }
}
