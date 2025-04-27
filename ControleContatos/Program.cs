using ControleContatos.Data;
using ControleContatos.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext com a string de conexão
builder.Services.AddDbContext<BancoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))); // Nome da string de conexão

builder.Services.AddScoped<IContatoRepositorio, ContatoRepositorio>();


// Adiciona os controladores com as views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline de requisição
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
