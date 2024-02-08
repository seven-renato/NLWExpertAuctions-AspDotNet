using Microsoft.EntityFrameworkCore;
using NLWExpert.API.Entities;

namespace NLWExpert.API.Repositories;

public class NLWExpertAuctionDbContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; } // Mesmo nome da tabela, guarda a referencia para ela

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\Courses\\DB Browser for SQLite\\leilaoDbNLW.db");
    }
}
