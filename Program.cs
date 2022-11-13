using Microsoft.EntityFrameworkCore;
using Wet;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WetContext>(options => options.UseSqlServer(connection));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.MapControllers();



app.Run();
