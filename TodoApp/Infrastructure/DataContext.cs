using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Infrastructure;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
    
    public DbSet<Product> Products { get; set; } = null!;

    public DbSet<Company> Companies { get; set; }= null!;

    public DbSet<Car> Cars { get; set; }= null!;

    public DbSet<Client> Clients { get; set; }= null!;

    public DbSet<Rent> Rents { get; set; }= null!;
}