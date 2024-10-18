var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<PetRepository>();

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddObjectType<Dog>()
    .AddObjectType<Cat>()
    .AddObjectType<Parrot>()
    .ModifyOptions(options => options.EnableOneOf = true);

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
