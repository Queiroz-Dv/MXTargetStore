using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class StoreContext : DbContext
  {
    public StoreContext(DbContextOptions options) : base(options)
    {
    }
    //Products is the name of the table in DB
    public DbSet<Product> Products { get; set; }
  }
}