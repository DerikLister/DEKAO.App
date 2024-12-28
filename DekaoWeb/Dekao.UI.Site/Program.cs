using Dekao.UI.Site.Data;
//using Dekao.UI.Site.Servicos;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;


var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Modulos/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
});


//builder.Services.AddDbContext<MeuDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("MeuDbContext")));

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();

//builder.Services.AddTransient<IOperacaoTransient, Operacao>();
//builder.Services.AddScoped<IOperacaoScoped, Operacao>();
//builder.Services.AddSingleton<IOperacaoSingleton, Operacao>();
//builder.Services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));

//builder.Services.AddTransient<OperacaoService>();

//builder.Services.AddScoped<MeuDbContext>();

var app = builder.Build();


//if (app.Environment.IsDevelopment())
//{
//    app.UseMigrationsEndPoint();
//}
//else
//{
//    app.UseExceptionHandler();
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Rota de área genérica (não necessário no caso da demo)
//app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute("AreaProdutos", "Produtos", "Produtos/{controller=Cadastro}/{action=Index}/{id?}");
app.MapAreaControllerRoute("AreaVendas", "Vendas", "Vendas/{controller=Pedidos}/{action=Index}/{id?}");


app.Run();
