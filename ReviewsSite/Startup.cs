using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ReviewsSite.Models;

namespace ReviewsSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepo>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddDbContext<Context>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvcWithDefaultRoute();

            //app.UseStaticFiles();//allows images files to be seen by html
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(              //alternative to setting default route
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
