[assembly: HostingStartup(typeof(Top2000.Areas.Identity.IdentityHostingStartup))]
namespace Top2000.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}