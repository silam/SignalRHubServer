using RealtimeSignalRServer.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSignalR();
builder.Services.AddCors(o => o.AddPolicy("AllowAnyOrigins", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("AllowAnyOrigins");

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.MapHub<LearningHub>("/learningHub");

app.Run();
