using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace webapp1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {   
            if (env.IsDevelopment())
            {
                Console.WriteLine("Development mode on");
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc();

            app.Run(RunContext);
        }

        private async Task RunContext(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World web app modified from console app");
        }
    }
}