/*
    Aula 8: Entendendo Rotas e Par�metros de Consulta
    
    Aplica��o Pr�tica: 
        Adicione um endpoint para recuperar um produto pelo ID e 
        outro para filtrar produtos por pre�o.
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
