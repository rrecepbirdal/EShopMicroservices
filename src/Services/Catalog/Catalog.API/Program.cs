var builder = WebApplication.CreateBuilder(args);


//Add services to the container. (Add functions)


var app = builder.Build();


//Configure the HTTP request pipeline. (Use functions.)


app.Run();
