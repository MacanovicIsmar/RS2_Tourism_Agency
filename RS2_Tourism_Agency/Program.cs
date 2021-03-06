using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RS2_Tourism_Agency.Filters;
using TourismAgency.Services;
using TourismAgency.Services.Database;
using TourismAgency.Services.PutovanjeStateMachine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//vs7 edit
builder.Services.AddControllers(x => {

    x.Filters.Add<ErrorFilter>();

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
{

    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"



    });


    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
       {

            new OpenApiSecurityScheme
            {

                Reference =new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id   = "basicAuth"
                
                },
                

            },
            new string []{}



       }

    });

            

});


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

//v6
builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<
        AuthenticationSchemeOptions,
        BasicAuthenticationHandler
        >
        ("BasicAuthentication", null);

//v7
builder.Services.AddTransient<Iservice<RS2_Tourism_Agency.Model.Uloge,RS2_Tourism_Agency.Model.SearchObjects.BaseSearchObject>, BaseService<RS2_Tourism_Agency.Model.Uloge,Uloge, RS2_Tourism_Agency.Model.SearchObjects.BaseSearchObject>>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();



app.MapControllers();

//v8
//using (var scope = app.Services.CreateScope())
//{
//    var dataContext = scope.ServiceProvider.GetRequiredService<Rs2_SeminarskiContext>();
//    dataContext.Database.Migrate();

//}



    app.Run();
