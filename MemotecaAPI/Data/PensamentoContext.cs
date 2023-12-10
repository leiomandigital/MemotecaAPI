using MemotecaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MemotecaAPI.Data;

public class PensamentoContext : DbContext
{
    public PensamentoContext(DbContextOptions<PensamentoContext> opts) : base(opts)
    {
            
    }

    public DbSet<Pensamento> Pensamentos { get; set; }
}
