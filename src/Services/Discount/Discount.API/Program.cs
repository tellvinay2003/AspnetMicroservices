using Discount.API.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Discount.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host =  CreateHostBuilder(args)
                .Build();

            // migrating our PostgreSql database, creating discountDb and Coupon table
            host.MigrateDatabase<Program>();
            host.Run();

            // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
