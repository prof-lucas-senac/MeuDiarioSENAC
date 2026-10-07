using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

app.MapPost("/login/auth", () =>
{
    TokenService authService = new TokenService(builder.Configuration);
    return authService.GerarToken(null);
});

var registrosGroup = app.MapGroup("/registros");

registrosGroup.MapGet("/", () => {
    List<Registro> registros = new RegistroService().ListarRegistros();
    return registros;
});

registrosGroup.MapPost("/", ([FromBody] Registro registro) => {
    new RegistroService().AdicionarRegistro(registro);
    return "Registro inserido com sucesso!";
});

app.Run();
