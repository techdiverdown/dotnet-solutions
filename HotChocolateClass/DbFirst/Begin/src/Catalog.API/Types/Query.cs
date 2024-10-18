namespace eShop.Catalog.Types;

// this class represents the root query type will contain all the queries that the client can execute
// this class will contain all the methods we call resolvers thta define how to fetch the data
// when a query is made
public class Query
{
    public IQueryable<Product> GetProducts(CatalogContext context) => context.Products;
    
    // another resolver
    public Task<Product?> GetProductById(int id, CatalogContext context) 
        => context.Products.FirstOrDefaultAsync(t => t.Id == id);
}