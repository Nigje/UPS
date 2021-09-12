using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UPS.Api.Models.Modules;
using UPS.DB;
using UPS.Framework.AspNet;
using UPS.Framework.DI;
using UPS.Framework.Orm.EntityFrameworkCode;

namespace UPS.Api
{
    public class Startup
    {
        //*********************************************************************************************************
        //Variables:
        public IConfiguration Configuration { get; }
        //*********************************************************************************************************
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //*********************************************************************************************************
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddUPSServices(Configuration);
            services.AddAutoMapper(typeof(AutoMapperProfile), typeof(BusinessServices.Mudole.AutoMapperProfile));
            services.AddDbContext<AppDBContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("UPS")), ServiceLifetime.Transient);
        }
        //*********************************************************************************************************
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseUPSApplication();


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Generate database.
            //For production use migration and database update in the command line and comment the following scop.
            using (var scope = app.ApplicationServices.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetService<AppDBContext>())
                {
                    context.Database.EnsureCreated();
                    context.Database.Migrate();
                }
            }
        }
        //*********************************************************************************************************
        /// <summary>
        /// ConfigureContainer is where you can register things directly
        /// with Autofac. This runs after ConfigureServices so the things
        /// here will override registrations made in ConfigureServices.
        /// Don't build the container; that gets done for you by the factory.
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DIModule());
            builder.RegisterModule(new UPSDIModule());
        }
        //*********************************************************************************************************
    }
}
