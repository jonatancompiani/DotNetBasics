/*
    Aula 5: Model Binding e Transferência de Dados

    Aplicação Prática: 
        Expanda a API de produtos para aceitar dados de produtos 
        via requisição POST e retornar o produto criado.

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
