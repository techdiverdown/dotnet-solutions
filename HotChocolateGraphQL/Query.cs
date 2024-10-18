using Microsoft.EntityFrameworkCore;
namespace HotChocolateGraphQL;

public class Query
{

    private readonly MyDbContext _dbContext;
    
    public Query(MyDbContext dbContext) 
    {
        _dbContext = dbContext;
    }
    
    public IQueryable<Book> GetBooks() => _dbContext.Books;
}   