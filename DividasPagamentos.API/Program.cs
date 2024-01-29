using DividasPagamentos.Application.AutoMappers;
using DividasPagamentos.Application.Interfaces;
using DividasPagamentos.Application.Services;
using DividasPagamentos.Infra.Context;
using DividasPagamentos.Infra.Interfaces;
using DividasPagamentos.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add in memory database
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

// Add AutoMappers
#region AutoMappers

builder.Services.AddAutoMapper(typeof(PessoaProfile));

#endregion

// Add Dependency Injections
#region Repositorios

builder.Services.AddTransient(typeof(IRepository<>), typeof(Repositorio<>));
builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();

#endregion 

#region Services

builder.Services.AddTransient<IPessoaService, PessoaService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
