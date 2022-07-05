using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SSC.Models;

namespace SSC {

    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddMvc().AddRazorPagesOptions(options => {
                options.Conventions.AddPageRoute("/Error", "");
            });
            services.AddDbContext<Campus6Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PowerCampus")));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseStatusCodePagesWithReExecute("/Error", "?code={0}");
            } else {
                app.UseHsts();
                app.UseStatusCodePagesWithReExecute("/Error", "?code={0}");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
            });
        }
    }
}