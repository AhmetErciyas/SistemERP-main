using ERP.Application;
using ERP.Data;
using ERP.Identity;
using ERP.IoC;
using ERP.IoC.Configuration;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using ERP.Domain.Core;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Domain.Security.Jwt;
using Microsoft.IdentityModel.Tokens;
using Domain.Security.Encyption;
using System.Text;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using ERP.WebApi.Authorization;

namespace ERP.WebApi
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
            services.AddSingleton(Configuration);

            // WebAPI Config
            services.AddControllers().AddNewtonsoftJson((options) =>
            {
                options.SerializerSettings.Converters.Add(new FilterItemConverter());
                options.SerializerSettings.Converters.Add(new SortItemConverter());
            });

            // Setting DBContexts
            services.AddDatabaseConfiguration(Configuration);

            // ASP.NET Identity Settings & JWT
            //services.AddApiIdentityConfiguration(Configuration);
            services.AddControllers();
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            string secretKey = Configuration["TokenOptions:SecurityKey"];

            var key = Encoding.ASCII.GetBytes(secretKey);
            
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidIssuer = tokenOptions.Issuer,
                       ValidAudience = tokenOptions.Audience,
                       ValidateIssuerSigningKey = true,
                       IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey),

                   };
               });
            services.AddAuthorization();

            // AutoMapper Settings
            services.AddAutoMapperConfiguration();

            // HttpContextAccessor
            services.AddHttpContextAccessor();

            // Swagger Config
            services.AddSwaggerConfiguration();

            // Adding MediatR for Domain Events and Notifications
            services.AddMediatR(typeof(Startup));

            // .NET Native DI Abstraction
            services.AddDependencyInjectionConfiguration(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwaggerSetup();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    public class CustomEFDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ICSharpEntityTypeGenerator, ERPEntityTypeGenerator>();
        }
    }
}
