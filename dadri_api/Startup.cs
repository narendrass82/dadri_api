using AspNetCoreRateLimit;
using dadri_api.Configurations;
using dadri_api.Data;
using dadri_api.IRepository;
using dadri_api.Repository;
using dadri_api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api
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

            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"));
                
            });
            
            services.AddMemoryCache();
            // inject counter and rules stores
            services.AddInMemoryRateLimiting();
            services.ConfigureRateLimiting();
            services.AddHttpContextAccessor();

            services.ConfigureHttpCacheHeaders();

            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureJWT(Configuration);

            services.AddCors(o =>
                o.AddPolicy("AllowAll",builder=>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader())
            );
            services.AddAutoMapper(typeof(MapperInitializer));// added to mapping data to dto mapping and reverse
            services.AddTransient<IUnitOfWork, UnitOfWork>();// this is device verytime freshh copy of IunitOfWork
            services.AddScoped<IAuthManager, AuthManager>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api", Version = "v1", Description="NTPC Dadri IT Api"});
            });

            services.AddControllers(config=> 
            {
                config.CacheProfiles.Add("120SecondsDuration", new CacheProfile
                {
                    Duration = 120                    
                });
                config.CacheProfiles.Add("60SecondsDuration", new CacheProfile
                {
                    Duration = 60
                });              

            }).AddNewtonsoftJson(
                options=>
                options.SerializerSettings.ReferenceLoopHandling= Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.ConfigureVersioning();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();                
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "dadri_api v1"));

            app.ConfigurationEceptionHandler();
            
            app.UseHttpsRedirection();
            
            app.UseCors("AllowAll");

            app.UseResponseCaching();
            app.UseHttpCacheHeaders();
            app.UseIpRateLimiting();

            app.UseRouting();

            //order matter
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
