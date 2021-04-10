using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Pos.Data.Implementation;
using Pos.Data.Intefaces;
using Pos.Models;

namespace Pos
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
            services.AddLocalization(Opt=>{
              Opt.ResourcesPath="Resources";
            });
            services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
            .AddDataAnnotationsLocalization();
            services.Configure<RequestLocalizationOptions>(opt => 
            {
              var SupportedCulture=new List<CultureInfo>
              {
                  new CultureInfo("en"),
                  new CultureInfo("ar")
              };
                 opt.DefaultRequestCulture=new Microsoft.AspNetCore.Localization.RequestCulture("en");
                 opt.SupportedCultures=SupportedCulture;
                 opt.SupportedUICultures=SupportedCulture;
            });
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(
                opt => opt.UseSqlServer(
                    Configuration.GetConnectionString("Conn")
                )
            );
            services.AddIdentity<ApplicationUsers,IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
           services.AddRazorPages();
           services.AddAuthorization(
               option => 
               {
                   option.AddPolicy("TestPolicy",policy => policy.RequireClaim("TestClaim"));
               }
           );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/Home/Error");
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            //   var SupportedCulture=new[] {"en","ar"};
            //   var LocalizationOptions=new RequestLocalizationOptions().SetDefaultCulture(SupportedCulture[0])
            //   .AddSupportedCultures(SupportedCulture)
            //   .AddSupportedUICultures(SupportedCulture);
            //   app.UseRequestLocalization(LocalizationOptions);
                
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
