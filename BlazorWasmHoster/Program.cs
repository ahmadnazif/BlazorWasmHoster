var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.WebHost.ConfigureKestrel(x =>
{
    var port = int.Parse(config["Port"]);
    x.ListenAnyIP(int.Parse(config["Port"]));
});

builder.Services.AddCors(x => x.AddDefaultPolicy(y => y.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

app.UseCors();

app.UseStaticFiles(new StaticFileOptions
{
    ServeUnknownFileTypes = true,
    OnPrepareResponse = ctx =>
    {
        if (ctx.File.Name.StartsWith("_framework"))
        {
            ctx.Context.Response.Headers.CacheControl = "public,max-age=31536000";
        }
    }
});

app.MapFallbackToFile("index.html");

await app.RunAsync();

