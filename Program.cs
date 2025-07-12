var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/little", () => "Hello Little Monkey World!");

app.Run();

