using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace sharpExercise
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("home", "/", new {controller = "Main", action = "Index"});
                endpoints.MapControllerRoute("default", "{controller=Main}/{action=Index}/{Id?}");
                endpoints.MapControllerRoute("page404", "/404", new {controller = "Main", action = "Page404"});
            });
            app.UseStatusCodePagesWithRedirects("/404");
        }
    }
}