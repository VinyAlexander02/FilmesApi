using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FilmContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("FilmConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// ADICIONE ESTA LINHA PARA REGISTRAR OS SERVIÇOS DOS CONTROLLERS
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// ADICIONE ESTA LINHA PARA MAPEAR AS ROTAS DOS SEUS CONTROLLERS
app.MapControllers();

app.Run();