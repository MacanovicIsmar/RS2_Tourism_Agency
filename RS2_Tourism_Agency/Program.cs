using Microsoft.EntityFrameworkCore;
using TourismAgency.Services;
using TourismAgency.Services.Database;
using TourismAgency.Services.PutovanjeStateMachine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//dadano v4 
//builder.Services.AddTransient<>


//dodano 
builder.Services.AddTransient<IPutovanjaServices ,PutovanjaService>();
//dodano v2
builder.Services.AddTransient<IKorisniciService, KorisniciService>();

//dodano v2
builder.Services.AddTransient<IGrupeService, GrupeService>();

//dodano v4
builder.Services.AddTransient<IDrzavaService, DrzavaService>();


//dodano v2
builder.Services.AddAutoMapper(typeof(IKorisniciService));

//dodano V2
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Rs2_SeminarskiContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//v5
//register state machine all states
builder.Services.AddTransient<BaseState>();
builder.Services.AddTransient<InitialPutovanjeState>();
builder.Services.AddTransient<PutovanjaDraftState>();
builder.Services.AddTransient<PutovanjeActiveState>();




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
