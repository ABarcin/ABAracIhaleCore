using AB_AracIhaleCore.API.Common;
using AB_AracIhaleCore.DAL.Abstract;
using AB_AracIhaleCore.DAL.Concrete;
using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.DAL.Concrete;
using AB_AracIhaleCore.DAL.Mapping;
using AB_AracIhaleCore.MODEL.Context;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AB_AracIhaleCore.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var server = Configuration["DBServer"] ?? ".";
            var user = Configuration["DBUser"] ?? "sa";
            var password = Configuration["DBPassword"] ?? "123";
            var database = Configuration["Database"] ?? "Slytherin_AracIhale";
            services.AddDbContext<Slytherin_AracIhaleContext>(options =>
            options.UseSqlServer($"Server={server},Initial Catalog={database};User ID={user},Password={password}"));
            var hede = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value);
            services.AddMvc().AddNewtonsoftJson();
            services.AddControllers()
            .AddJsonOptions(options =>
            options.JsonSerializerOptions.Converters.Add(new TimeSpanToStringConverter()));
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            });
            services.AddAuthorization();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(hede),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            services.AddTransient<IAracTramerDAL, AracTramerDAL>();
            services.AddTransient<IAracTramerDetayDAL, AracTramerDetayDAL>();
            services.AddTransient<IKullaniciDAL, KullaniciDAL>();
            services.AddTransient<IIhaleDAL, IhaleDAL>();
            var config = new AutoMapper.MapperConfiguration(cfg =>
              {
                  cfg.AddProfile(new MapProfile());
  
              });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseCors();
            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
