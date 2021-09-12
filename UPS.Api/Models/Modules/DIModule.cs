using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UPS.Framework.DI;

namespace UPS.Api.Models.Modules
{
    public class DIModule : Autofac.Module
    {
        /// <summary>
        /// Register objects.
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {

            var assemblies = Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly)
               .Select(Assembly.LoadFrom);

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .Where(x => x.IsAssignableTo<ITransientLifetime>()).AsSelf().AsImplementedInterfaces()
                .InstancePerDependency();

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .Where(x => x.IsAssignableTo<IScopedLifetime>()).AsSelf().AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterAssemblyTypes(assemblies.ToArray())
                .Where(x => x.IsAssignableTo<ISingletonLifetime>()).AsSelf().AsImplementedInterfaces()
                .SingleInstance();

        }
    }
}

