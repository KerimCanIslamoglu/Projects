using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CourseApp304.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Configuration;
using CourseApp304.Data.Concrete;
using CourseApp304.Data.Abstract;

namespace CourseApp304
{
    public class Startup
    {
        public IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(); //Projeye MVC  olarak kullanacağımı deklere ediyorum.

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DataConnection"));
                options.EnableSensitiveDataLogging(true);
            });
            services.AddDbContext<UserContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("UserConnection"));                
            });
            
            services.AddTransient<ICourseRepository, EfCourseRepository>();
            services.AddTransient<IInstructorRepository, EfInstructorRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IGenericRepository<Contact>,GenericRepository<Contact>>();
            services.AddTransient<IGenericRepository<Address>, GenericRepository<Address>>();
            services.AddTransient<IGenericRepository<Student>, GenericRepository<Student>>();
            services.AddTransient<IUserRepository,UserRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,DataContext dataContext,UserContext userContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed(dataContext);
                SeedDatabase.Seed(userContext);

            }
            app.UseDeveloperExceptionPage();//Bu kodu dışarı alarak alınan hatayı kullanıcı da görsün istiyoruz.
            
            app.UseStatusCodePages();//Hata sayfalarını görmemize yarıyor.(404 not found,502 gibi..) Eğer bu kodu yazmazsak hata alınır ama hata aldığımızı göremeyiz.

            app.UseStaticFiles(); //wwwroot=> Tarayıcı tarafından ulaşılması gereken css,js ve image gibi dosyaları toplu halde barındıran ve core yapısının dışarı açılan kapısıdır. Sisteme bunu tanıtmak için bu kodu yazıyoruz.

            app.UseStaticFiles(new StaticFileOptions() {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/vendor") 
            });

            app.UseMvcWithDefaultRoute();//Route kullanımı için burada  eklememiz gerekiyor.
        }
    }
}
