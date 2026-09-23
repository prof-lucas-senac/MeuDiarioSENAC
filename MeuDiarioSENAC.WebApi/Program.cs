var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Boa noite!");

app.MapGet("/motivacional", () => "Lembre-se: todo mês tem boleto!");

app.MapGet("/registros", () => {
    List<Registro> registros = new RegistroService().ListarRegistros();
    return registros;
});
app.Run();
