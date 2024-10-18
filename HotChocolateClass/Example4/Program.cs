using Example4.Types;
var builder = WebApplication.CreateBuilder(args);

// register services with all the types
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Dog>()
    .AddType<Cat>()
    .AddType<Parrot>()
    .ModifyOptions(o => o.EnableOneOf = true);

var app = builder.Build();

app.MapGraphQL();

app.Run();

