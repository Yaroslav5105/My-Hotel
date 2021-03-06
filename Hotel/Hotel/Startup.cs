using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Data;
using Hotel.Data.interfaces;
using Hotel.Data.mocks;
using Hotel.Data.Models;
using Hotel.Data.Repository;
using Hotel.interfaces;
using Hotel.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;




namespace Hotel
{
    public class Startup
    {


        private IConfigurationRoot _confSting;

        public Startup(IHostingEnvironment hostEnv) {
            _confSting = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confSting.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllRoom, RoomRepository>();
            services.AddTransient<IRoomCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrdersRepository>();
           
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => HotelRoom.GetRoom(sp));

           //  services.AddMvc();
            services.AddMvc(x => x.EnableEndpointRouting = false);

            services.AddMemoryCache();
            services.AddSession();

            // ��������� ������������ �����������
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => {
                options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
            });
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();��� // ��������������
������������app.UseAuthorization();     // �����������

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();

                DbObjects.Initial(content);
            }

            
        }
    }
}
