using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

# region Mapper Configuration
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new Domain.Mappings.ToDoProfile());
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

// Database Context
builder.Services.AddDbContext<Data.DatabaseContext>(options =>
{
    options.UseSqlServer
        (builder.Configuration.GetConnectionString("MyConnectionString"));
});

// builder.Services.AddTransient<Data.IUnitOfWork, Data.UnitOfWork>();

// builder.Services.AddTransient<Data.IUnitOfWork, Data.UnitOfWork>(sp =>
//             {
//                 Utility.Tools.Options options =
//                     new Utility.Tools.Options
//                     {
//                         Provider =
//                             (Utility.Tools.Enums.Provider)
//                             System.Convert.ToInt32(builder.Configuration.GetSection(key: "databaseProvider").Value),

//                         //using Microsoft.EntityFrameworkCore;
//                         ConnectionString =
//                             builder.Configuration.GetConnectionString("MyConnectionString"),

//                         // ConnectionString =
//                         //     builder.Configuration.GetSection(key: "ConnectionStrings").GetSection(key: "MyConnectionString").Value,
//                     };

//                 return new Data.UnitOfWork(options: options);
//             });

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
