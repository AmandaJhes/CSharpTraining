var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

//Informa a estrura que será utilizada no projeto
var app = builder.Build();

//Realiza requisições utilizando o https
app.UseHttpsRedirection();
//Utiliza Arquivos Estáticos que estão no diretório wwwroot
app.UseStaticFiles();

//Auxilia no mapeamento das páginas
app.UseRouting();
app.MapRazorPages();


app.Run();
