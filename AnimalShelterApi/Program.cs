using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AnimalShelterApiContext>(
                dbContextOptions => dbContextOptions
                .UseMySql(
                    builder.Configuration["ConnectionStrings:DefaultConnection"], 
                    ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                )
                )
            );
builder.Services.AddApiVersioning(opt =>
                {
                    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1,0);
                    opt.AssumeDefaultVersionWhenUnspecified = true;
                    opt.ReportApiVersions = true;
                    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                                    new HeaderApiVersionReader("x-api-version"),
                                                                    new MediaTypeApiVersionReader("x-api-version"));
                });

builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.ResolveConflictingActions(c=>c.Last());
    }
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
