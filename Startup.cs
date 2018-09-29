using FiapWeb.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FiapWeb
{
    public class Startup
    {
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    app.Run(async (context) =>
        //    {
        //        await context.Response.WriteAsync("Ola Fiap!!!");
        //    });
        //}

        public void ConfigureServices(IServiceCollection service)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

            service.AddDbContext<PerguntaContext>(o => o.UseSqlServer(connection));

            service.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

           if(env.IsDevelopment())
                app.UseDeveloperExceptionPage();


            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=index}/{id?}");
            });

            //app.UseMvc(routes =>
            //{
            //    //routes.MapRoute(
            //    //    name: "autor",
            //    //    template: "Autor/{nome}", 
            //    //    defaults: new { controller = "Autor", action = "Index" });
            //    //routes.MapRoute(
            //    //    name: "autoresDoAno",
            //    //    template: "{ano:int}/autor",
            //    //    defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" });
            //    //routes.MapRoute(
            //    //    name: "topicosdacategoria",
            //    //    template: "{categoria}/{topico}",
            //    //    defaults: new { controller = "Topicos", action = "index" });
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=index}/{id?}");
            //});
        }


    }

}
