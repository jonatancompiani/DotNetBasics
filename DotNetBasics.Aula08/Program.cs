/*
    Aula 8: Entendendo Rotas e Parâmetros de Consulta
    
    Aplicação Prática: 
        Adicione um endpoint para recuperar um produto pelo ID e 
        outro para filtrar produtos por preço.
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
