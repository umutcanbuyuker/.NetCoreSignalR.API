using ChatService;
using ChatService.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => 
    { 
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});
builder.Services.AddSingleton<IDictionary<string,UserConnection>>(opts => new Dictionary<string,UserConnection>());
var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "Hello World!");

app.MapHub<ChatHub>("/chat");

app.Run();
