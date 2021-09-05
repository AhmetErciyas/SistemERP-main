using Domain.Security.Jwt;
using ERP.Application;
using ERP.Application.AutoMapper;
using ERP.Application.Interfaces;
using ERP.Application.Services;
using ERP.Data;
using ERP.Domain.Commands.Base;
using ERP.Domain.Core;
using ERP.Domain.ServiceClient.KISI;
using ERP.Domain.ServiceClient.MAIL;
using ERP.Domain.ServiceClient.SMS;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ERP.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            Services = services;

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            // AutoMapper
            services.AddScoped<IERPMapper, ERPMapper>();

            // Application
            services.AddScoped<ISampleService, SampleService>();
            services.AddScoped<IPersonelService, PersonelService>();
            services.AddScoped<IOrganizasyonService, OrganizasyonService>();
            services.AddScoped<IKullaniciService, KullaniciService>();
            services.AddScoped<IFinansService, FinansService>();
            services.AddScoped<IFirmaSubeService, FirmaSubeService>();
          
            services.AddScoped<IKullaniciYetkileriService, KullaniciYetkileriService>(); 
            services.AddScoped<IYetkiGruplariDetayService, YetkiGruplariDetayService>();
            services.AddScoped<IYetkiGruplariService, YetkiGruplariService>();
            services.AddScoped<IYetkilerService, YetkilerService>();
           



            // Domain - Meadiator
            services.AddScoped(typeof(IRequestHandler<,>), typeof(BasePagedListeleQueryHandler<>));
            services.AddScoped(typeof(IRequestHandler<,>), typeof(BaseListeleQueryHandler<>));
            services.AddScoped(typeof(IRequestHandler<,>), typeof(BaseGetirQueryHandler<,>));

            services.AddImplementedInterfaces(assemblies, typeof(IRequestHandler<,>));
            services.AddImplementedInterfaces(assemblies, typeof(INotificationHandler<>));

            // Domain - Services
            services.AddScoped<IMailServiceClient, MailServiceClient>();
            services.AddScoped<ISMSServiceClient, SMSServiceClient>();
            services.AddScoped<IKisiServiceClient, KisiServiceClient>();

            // Infrastructure - Data
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDatabaseConfiguration(configuration);

            
            // Repositories
            services.AddAllRepositoryTypes(typeof(IRepository<>), assemblies);

            // HttpContext
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ITokenHelper, JwtHelper>();

            //EF Scaffold
            //TODO : EntityTypeGenerator yazılacak
        }

        public static IServiceCollection Services { get; private set; }
    }
}
