using Microsoft.EntityFrameworkCore;
using TourismAgency.Services;
using TourismAgency.Services.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//dodano 
builder.Services.AddTransient<IPutovanjaServices ,PutovanjaService>();
//dodano v2
builder.Services.AddTransient<IKorisniciService, KorisniciService>();

//dodano v2
builder.Services.AddTransient<IGrupeService, GrupeService>();


//dodano v2
builder.Services.AddAutoMapper(typeof(IKorisniciService));

//dodano V2
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Rs2_SeminarskiContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
