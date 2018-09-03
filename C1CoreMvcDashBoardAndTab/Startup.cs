using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C1CoreMvcDashBoardAndTab
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            C1.Web.Mvc.LicenseManager.Key = "c1v01woDFnsWCxIbCqsW/xI/Ek8OiVMKOxI5zxYTCu8SAxZ7EvsWRw4DEpMOjxIdYxYbCgcK7wovDhMOaw7jEl8KmxKvDisKhxI/FhcWRwofEhMKXw6PDucO3w4jCvMO6w5rDmsScecK0xIRixJ3EusSla8Kew5fEtsWAw4o/woXDi8KBxLrDlMOIw4rEsMKbxKLEs2jChMK8w4dwxJTDmcONU8SWfsS8wqPClzrDtsKew6DErMWCwpzEvcKvxJzCoMOmxJLErsOfwp7DgMKiw4XEu8K/U03DjsWLwrjEh8SiacSpwrPEr8OjU8SuwpXEu8S5w4B/xJDCq8OGwrTEtcOxwqzFpcOwwqnDsH3CvU93wqDFlMS0U8K/wqpxwqvDsA==";
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
