using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using webapp;

[assembly: HostingStartup(typeof(webapp.Areas.Identity.IdentityHostingStartup))]
namespace webapp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                // services.AddDbContext<Myweb>(options =>
                //     options.UseSqlServer(
                //         context.Configuration.GetConnectionString("MywebConnection")));

                //  services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                // .AddEntityFrameworkStores<Myweb>();

            //      services.AddIdentity<AppUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            //  .AddEntityFrameworkStores<MyWeb>();
            });
        }
    }
}