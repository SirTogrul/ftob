
using weebapp.DAL;

var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
                  opt.UseSqlServer("")

});
            app.MapControllerRoute(
                
                name:"default",
                pattern:"{controller=home}/{action=index}/{id?}"                   
                );
            app.Run();
