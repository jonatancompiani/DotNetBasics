/*
    Aula 3: Introdução às Web APIs e HTTP

    Aplicação Prática: 
        Crie uma Web API básica com um endpoint que receba os 
        dados de uma operação matemática e retorne o resultado
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
