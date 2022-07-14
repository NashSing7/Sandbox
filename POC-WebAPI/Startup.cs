using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace POC_WebAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            

            var dbServer = Configuration["DBServer"] ?? "localhost";
            var dbPort = Configuration["DBPort"] ?? "1433";
            var dbUser = Configuration["DBUser"] ?? "SA";
            var dbPassword = Configuration["DBPassword"] ?? "Password123";
            var dbDatabase = Configuration["DBDatabase"] ?? "DapperEFPoc";

            
            // TODO: Add the string here and inject the env variables above
            
            services.AddDbContext<AppContext>(options =>
                      options.UseSqlServer(
                          Configuration.GetConnectionString("default")));
            //Register dapper in scope    
            services.AddSingleton<IDapper, DapperService>();
            services.AddSingleton<IUser, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseMvc();
        }
    }
}
