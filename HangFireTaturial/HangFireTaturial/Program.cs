using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Hangfire;
using HangFireTaturial;
using HangFireTaturial.Implamation;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
//add desc to api
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1",
//        new Info
//        {
//            Title = "My API - V1",
//            Version = "v1"
//        }
//     );

//    var filePath = Path.Combine(System.AppContext.BaseDirectory, "MyApi.xml");
//    c.IncludeXmlComments(filePath);
//});
// Add services to the container.
//builder.Services.AddHangFire(configuration => configuration
//        .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
//        .UseSimpleAssemblyNameTypeSerializer()
//        .UseRecommendedSerializerSettings()
//        .UseSqlServerStorage(Configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
//        {
//            CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
//            SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
//            QueuePollInterval = TimeSpan.Zero,
//            UseRecommendedIsolationLevel = true,
//            DisableGlobalLocks = true
//        }));

builder.Services.AddControllers();
//builder.Services.AddScoped<IHang, HangRepo>();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "HangfireApplication", Version = "v1" });
//});
//builder.Services.AddHangfire(x =>
//{
//    x.UseSqlServerStorage(builder.Configuration.GetConnectionString("DBConnection"));
//});
//builder.Services.AddHangfireServer();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddHangfireServer();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
//app.UseHangfireDashboard();
app.Run();
