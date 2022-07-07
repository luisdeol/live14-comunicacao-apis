using PokeAcademy.API.Services;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

const string BASE_URL = "https://pokeapi.co/api/v2";
const string EXTERNAL_BASE_URL = "https://localhost:7235";

builder
    .Services
    .AddRefitClient<IPokeService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(BASE_URL));

builder
    .Services
    .AddRefitClient<IExternalService>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(EXTERNAL_BASE_URL));

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
