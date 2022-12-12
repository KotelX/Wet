using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Wet;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            // ���������, ����� �� �������������� �������� ��� ��������� ������
//            ValidateIssuer = true,
//            // ������, �������������� ��������
//            ValidIssuer = AuthOptions.ISSUER,
//            // ����� �� �������������� ����������� ������
//            ValidateAudience = true,
//            // ��������� ����������� ������
//            ValidAudience = AuthOptions.AUDIENCE,
//            // ����� �� �������������� ����� �������������
//            ValidateLifetime = true,
//            // ��������� ����� ������������
//            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
//            // ��������� ����� ������������
//            ValidateIssuerSigningKey = true,
//        };
//    });
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => options.LoginPath = "/login");
builder.Services.AddAuthorization();

builder.Services.AddRazorPages();
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WetContext>(options => options.UseSqlServer(connection));
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.MapControllers();



app.Run();
