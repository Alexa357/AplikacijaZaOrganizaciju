using AplikacijaZaOrganizaciju.OrganizacijaContext;
using AplikacijaZaOrganizaciju.Repository;
using AplikacijaZaOrganizaciju.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OrganizacijaDbContext>(options =>
                  options.UseMySQL("Server=127.0.0.1;Port=3306;Database=organizacija;User ID=root;Password=;"));
builder.Services.AddScoped<IKorisnikRepository, KorisnikRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var builded = builder.Services.BuildServiceProvider();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(options =>
{
    options.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();
});

app.Run();

