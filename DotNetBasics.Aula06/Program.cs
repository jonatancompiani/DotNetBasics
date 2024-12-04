/*
    Aula 7: Introdu��o ao Tratamento de Erros

    Aplica��o Pr�tica: 
        Adicione tratamento b�sico de erros � API de produtos 
        para gerenciar entradas inv�lidas ou dados ausentes.
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
