/*
    Aula 3: Introdu��o �s Web APIs e HTTP

    Aplica��o Pr�tica: 
        Crie uma Web API b�sica com um endpoint que receba os 
        dados de uma opera��o matem�tica e retorne o resultado
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
