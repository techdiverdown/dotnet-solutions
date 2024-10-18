var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>();


var app = builder.Build();

app.MapGraphQL();

app.Run();

public class Query
{
    // This is a resolver, it fetches the data
    // this is the annotation based approach
    // this will be translasted into this in graphql: (SDL)
    // type Query {
    //    sayHello(firstName: String! = "Hello", lastName: String! = "World"): String!
    //    Field.........Argument         Default value   ...the ! means its not nullable                          
    public string? SayHello(string? firstName = "Hello", string lastName = "World")
    {
        return $"Hello {firstName} {lastName}!";
    }
    
    public string SayGoodbye() => "Goodbye!";   
}
