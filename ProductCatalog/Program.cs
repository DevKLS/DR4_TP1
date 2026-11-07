
using ProductCatalog.Models;
using ProductCatalog.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços Razor Pages
builder.Services.AddRazorPages();

// Registro do serviço responsável pelos logs
builder.Services.AddSingleton<EventLogger>();

// Registro do delegate Action<Event>
builder.Services.AddSingleton<Action<Event>>(serviceProvider =>
{
    var logger = serviceProvider.GetRequiredService<EventLogger>();

    return logger.LogEvent;
});

var app = builder.Build();

// Configuração do ambiente HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configuração das páginas Razor
app.MapRazorPages();

app.Run();
