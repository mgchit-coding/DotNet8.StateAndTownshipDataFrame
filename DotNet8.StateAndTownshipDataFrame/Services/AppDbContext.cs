using DotNet8.StateAndTownshipDataFrame.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.StateAndTownshipDataFrame.Services;

public class AppDbContext:DbContext
{
    private readonly string _connectionStr = "Server=.;Database=Pos;User ID=sa;Password=sasa@123;TrustServerCertificate=True;";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionStr);
    }
    public DbSet<StateDataModel> State { get; set; }
}
