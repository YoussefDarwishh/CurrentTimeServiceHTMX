var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/date", () =>
{
    var currentDateTime = DateTime.Now.ToString();
    return Results.Text(currentDateTime, "text/plain");
});

app.Run();