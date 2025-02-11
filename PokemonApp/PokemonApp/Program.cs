using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PokemonApp.Context;
using PokemonApp.Interfaces;
using PokemonApp.Security;
using PokemonApp.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Register authentication services
var domain = $"https://{builder.Configuration["Auth0:Domain"]}/";
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.Authority = domain;
    options.Audience = builder.Configuration["Auth0:Audience"];
    options.TokenValidationParameters = new TokenValidationParameters
    {
        NameClaimType = ClaimTypes.NameIdentifier
    };
});


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IPokemonServices, PokemonServices>();
builder.Services.AddDbContext<PokemonAppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("read:messages", policy => policy.Requirements.Add(new
    HasScopeRequirement("read:messages", domain)));
});

builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

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

app.Run();
