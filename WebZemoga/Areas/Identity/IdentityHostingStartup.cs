using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebZemoga.Data;

[assembly: HostingStartup(typeof(WebZemoga.Areas.Identity.IdentityHostingStartup))]
namespace WebZemoga.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebZemogaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebZemogaContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebZemogaContext>();
            });
        }
    }
}