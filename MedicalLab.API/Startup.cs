using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using MedicalLab.Model;
using MedicalLab.Repository;
using MedicalLab.RepositoryInterface;
using MedicalLab.Service;
using MedicalLab.ServiceInterface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Unity;

namespace MedicalLab.API
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
            Register();
            DataBaseSettings setting = new DataBaseSettings() { ConnectionString = "mongodb://localhost:27017", DatabaseName = "medicalLab" };
            services.AddControllers();
            //services.AddTransient<IRepositoryStore>(s => new RepositoryStore(setting));
            services.AddTransient<IUserService>(s => new UserService(setting));
            services.AddTransient<ITestResultService>(s => new TestResultService(setting));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void Register()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IUsersRepository, UserRepository>();
            container.RegisterType<IUserService, UserService>();
            //container.RegisterType<IUsersRepository, UserRepository>();
        }
    }
}
