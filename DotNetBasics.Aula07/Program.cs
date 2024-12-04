/*
    Aula 7: Introdução ao Tratamento de Erros

    Aplicação Prática: 
        Adicione tratamento básico de erros à API de produtos 
        para gerenciar entradas inválidas ou dados ausentes.
*/

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
