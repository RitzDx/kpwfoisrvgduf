using CrypticSource.WebSocket;

var builder = WebApplication.CreateBuilder(args);

/* this checks if the data directory does not exist
   and if it does not exist it creates the data directory
*/
if (!Directory.Exists(Environment.CurrentDirectory + "/Data"))
{
    Directory.CreateDirectory(Environment.CurrentDirectory + "/Data");
}

builder.Services.AddHttpLogging(configureOptions => {});

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.UseHttpLogging();

app.MapControllers();

new WebSocket();

app.Run();
