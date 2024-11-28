using PainelDeGestãoDeProfissionais.Infra.Repositories;
using PainelDeGestãoDeProfissionais.Aplication.Services;
using PainelDeGestãoDeProfissionais.Aplication.Services.Interfaces;
using PainelDeGestãoDeProfissionais.Infra;
using SQLite;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorBootstrap();

string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "Gestao.db3");

if (!File.Exists(dbPath))
{
    Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
}

builder.Services.AddSingleton<SQLiteAsyncConnection>(provider =>
{
    return new SQLiteAsyncConnection(dbPath);
});

builder.Services.AddSingleton<SQLiteInitializer>();

builder.Services.AddScoped<IProfissionaisRepository, ProfissionaisRepository>();
builder.Services.AddScoped<IEspecialidadesRepository, EspecialidadesRepository>();


builder.Services.AddScoped<IProfissionaisService, ProfissionaisService>();
builder.Services.AddScoped<IToastServiceNotify, ToastServiceNotify>();


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<SQLiteInitializer>();
    await context.InitializeAsync();
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
