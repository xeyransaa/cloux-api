using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ClouxDbContext>()
            .AddDefaultTokenProviders();
builder.Services.AddDbContext<ClouxDbContext>();
builder.Services.AddScoped<IGameDal, EFGameDal>();
builder.Services.AddScoped<IGameCategoryDal, EFGameCategoryDal>();
builder.Services.AddScoped<IGamePlatformDal, EFGamePlatformDal>();
builder.Services.AddScoped<IGameManager, GameManager>();
builder.Services.AddScoped<IGameCategoryManager, GameCategoryManager>();
builder.Services.AddScoped<IGamePlatformManager, GamePlatformManager>();
builder.Services.AddScoped<ISocialMediaManager, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();
builder.Services.AddScoped<IPlatformManager, PlatformManager>();
builder.Services.AddScoped<IPlatformDal, EFPlatformDal>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryManager, CategoryManager>();
builder.Services.AddScoped<ILanguageDal, EFLanguageDal>();
builder.Services.AddScoped<ILanguageManager, LanguageManager>();
builder.Services.AddScoped<IBlogDal, EFBlogDal>();
builder.Services.AddScoped<IBlogManager, BlogManager>();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IMessageManager, MessageManager>();
builder.Services.AddScoped<IMessageDal, EFMessageDal>();
builder.Services.AddScoped<IGameLanguageTypeLDal, EFGameLanguageTypeLDal>();
builder.Services.AddScoped<IGameLanguageTypeLManager, GameLanguageTypeLManager>();
builder.Services.AddScoped<IGameDeveloperDal, EFGameDeveloperDal>();
builder.Services.AddScoped<IGameDeveloperManager, GameDeveloperManager>();

builder.Services.AddScoped<TokenManager>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson
    (options =>    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "_myAllowOrigins",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithMethods("PUT", "DELETE", "GET");
        }
     );
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.SaveToken = true;
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

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

app.UseCors("_myAllowOrigins");

app.MapControllers();

app.Run();
