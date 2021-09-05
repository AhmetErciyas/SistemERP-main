using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ERP.IoC
{
    public static class ServiceCollectionExtentions
    {
        public static void AddAllRepositoryTypes(this IServiceCollection services,
                                                            Type t,
                                                            Assembly[] assemblies,
                                                            ServiceLifetime lifetime = ServiceLifetime.Scoped
        )
        {
            assemblies = assemblies.Where(a => !a.FullName.Contains("Microsoft.VisualStudio.TraceDataCollector")).ToArray();

            var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == t)));

            var repositoryInterfaceTypesFromAssemblies = typesFromAssemblies.Where(q => q.IsInterface).ToList();

            foreach (var repositoryInterfaceType in repositoryInterfaceTypesFromAssemblies)
            {
                var baseRepositoryType = typesFromAssemblies.FirstOrDefault(q => q.ImplementedInterfaces.Any(i => i == repositoryInterfaceType));
                var entityType = repositoryInterfaceType.ImplementedInterfaces.FirstOrDefault();
                if (baseRepositoryType != null)
                    services.Add(new ServiceDescriptor(repositoryInterfaceType, baseRepositoryType, lifetime));
                if (baseRepositoryType != null && entityType != null)
                    services.Add(new ServiceDescriptor(entityType, baseRepositoryType, lifetime));
            }
        }

        private static List<TypeInfo> GetTypesAssignableTo(this Assembly assembly, Type compareType)
        {
            if (assembly.FullName.Contains("Microsoft.VisualStudio.TraceDataCollector"))
                return new List<TypeInfo>();
            var typeInfoList = assembly.DefinedTypes.Where(x => x.IsClass &&
                                                                !x.IsAbstract &&
                                                                x != compareType &&
                                                                x.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == compareType)
                                                            )?.ToList();
            return typeInfoList;
        }

        public static void AddImplementedInterfaces(this IServiceCollection services,
                                                                Assembly[] assemblies,
                                                                Type compareType,
                                                                ServiceLifetime lifetime = ServiceLifetime.Scoped)
        {
            assemblies.ToList().ForEach((assembly) =>
            {
                assembly.GetTypesAssignableTo(compareType).ForEach((type) =>
                {
                    foreach (var implementedInterface in type.ImplementedInterfaces)
                    {
                        if (!string.IsNullOrEmpty(implementedInterface.FullName))
                        {
                            services.Add(new ServiceDescriptor(implementedInterface, type, lifetime));
                        }
                    }
                });
            });
        }
    }
}