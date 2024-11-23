using cinama.Data;
using cinama.Reposatiory.CategoryRepo;
using cinama.Reposatiory.DirectorRepo;
using cinama.Reposatiory.MoviesRepo;
using cinama.Reposatiory.NationaltyRepo;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbcontext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped<IMovieeRepo,MovieeRepo>();
builder.Services.AddScoped<IDirectoryRepo,DirectoryRepoo>();
builder.Services.AddScoped<ICategoryRepo,CategoryRepoo>();
builder.Services.AddScoped<INationalRepo,NationalRepoocs>();
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
