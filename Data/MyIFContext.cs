using Microsoft.EntityFrameworkCore;
using MyIF.Models;
namespace MyIF.Data;

public class MyIFContext : DbContext
{
    public MyIFContext(DbContextOptions<MyIFContext> options) : base(options)
    {       
    }

    public DbSet<Curse> Curses { get; set; }
}
