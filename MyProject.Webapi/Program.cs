
//using Mock;
using DataContext;
using MyProject.Repository.Interfaces;
using MyProject.Service;
using MyProject.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddFile("log/mylog-{Date}.txt");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServices();
builder.Services.AddDbContext<IContext, DataContext1>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("http://localhost:3001",
                                "http://www.contoso.com")
                                        .AllowAnyHeader()
                                      .AllowAnyMethod();
        });
});
//builder.Services.AddScoped<ire>
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
