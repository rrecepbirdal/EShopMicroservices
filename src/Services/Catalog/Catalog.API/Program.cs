using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


//Add services to the container. (Add functions)
builder.Services.AddCarter(new DependencyContextAssemblyCatalog([typeof(Program).Assembly]));
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});
builder.Services.AddMarten(config =>
{
    config.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();

var app = builder.Build();


//Configure the HTTP request pipeline. (Use functions.)
app.MapCarter();

app.Run();


