using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using FADMS.DAL.AuthService;
using FADMS.DAL.AuthService.Interfaces;
using FADMS.DAL.FamsDealerService;
using FADMS.DAL.FamsDealerService.Interface;
using FADMS.DAL.RepositoryService;
using FADMS.DAL.RepositoryService.Interfaces;
using FADMS.DAL.Services;
using FADMS.DAL.Services.Interfaces;
using FADMS.Data;
using FADMS.Data.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace FADMS
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddScoped<IItemCodeService, ItemCodeService>();
            services.AddScoped<IITemService, ItemService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IDealerService, DealerService>();
            services.AddScoped<IGunRepairService, GunRepairService>();

            #region Purchase
            services.AddScoped<IPurchaseService, PurchaseService>();
            services.AddScoped<IItemsService, ItemsService>();
            #endregion

            #region Salese
                services.AddScoped<ISalesService, SalesService>();
            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options =>
                {
                    var resolver = options.SerializerSettings.ContractResolver;
                    if (resolver != null)
                        (resolver as DefaultContractResolver).NamingStrategy = null;
                });

            services.AddSession(options =>
            {
                options.Cookie.Name = ".AdventureWorks.Session";
                options.IdleTimeout = TimeSpan.FromHours(24);
                options.Cookie.IsEssential = true;
            });

            services.AddHttpContextAccessor();

            #region ERP Database Settings
            services.AddDbContext<FADMSDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("FADMSConnection")));

            services.AddMemoryCache();
            //.AddDefaultTokenProviders();
            services.AddIdentity<ApplicationUser, ApplicationRole>()
               .AddEntityFrameworkStores<FADMSDbContext>().AddDefaultTokenProviders();
            //services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ERPDbContext>();
            #endregion

            #region Auth JWT
            //services.AddSingleton<IJwtFactoryService, JwtFactoryService>();
            //var jwtAppsettingsOptions = Configuration.GetSection(nameof(JwtIssuerOptions));

            //SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtAppsettingsOptions["SecreatKey"]));

            //services.Configure<JwtIssuerOptions>(Options =>
            //{
            //    Options.Issuer = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Issuer)];
            //    Options.Audience = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Audience)];
            //    Options.SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
            //});

            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    ValidateIssuer = true,
            //    ValidIssuer = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Issuer)],

            //    ValidateAudience = true,
            //    ValidAudience = jwtAppsettingsOptions[nameof(JwtIssuerOptions.Audience)],

            //    ValidateIssuerSigningKey = true,
            //    IssuerSigningKey = _signingKey,

            //    RequireExpirationTime = false,
            //    ValidateLifetime = true,
            //    ClockSkew = TimeSpan.Zero
            //};
            #endregion

            #region Auth Related Settings
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);

                options.LoginPath = "/Auth/Account/Login";
                options.AccessDeniedPath = "/Auth/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            #endregion

            #region Areas Config
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("/areas/{2}/Views/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/areas/{2}/Views/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
            #endregion

            #region PDF
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            #endregion

            #region Master Data
            services.AddScoped<IUserInfoes, UserInfoes>();
            services.AddScoped<IAddressService, AddressService>();
      
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            #endregion

            #region Dashboard
            //services.AddScoped<IDashboardService, DashboardService>();
        
            #endregion
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            //app.UseDeveloperExceptionPage();
            //app.UseDatabaseErrorPage();


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            
            app.UseSession();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}