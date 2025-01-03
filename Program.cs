using InventoryManagementSystem.Components;
using Serilog;

var loggerConfiguration = new LoggerConfiguration()
    .WriteTo.Console();

Log.Logger = loggerConfiguration.CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddRazorComponents(options => 
//     options.DetailedErrors = builder.Environment.IsDevelopment());

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddCommandLine(args)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables();

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddSingleton<SqlConfiguration>();
builder.Services.AddSingleton<ISqlConnector,SqlConnector>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
