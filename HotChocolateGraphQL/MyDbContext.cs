namespace HotChocolateGraphQL;
using Microsoft.EntityFrameworkCore;
public class MyDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }
}