using AutoMapper;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

# region Mapper Configuration
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new WA.Domain.Mappings.ToDo.ToDoProfile());
});

var mapper = config.CreateMapper();
# endregion / Mapper Configuration

# region Add services to the container
// Auto Mapper
builder.Services.AddSingleton(mapper);

// Fluent Validation 
builder.Services.AddControllers()
    .AddFluentValidation(current =>
                {
                    current.RegisterValidatorsFromAssemblyContaining<Program>();
                });
;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

# endregion / Add services to the container

# region App Run and Setting 
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
# endregion
