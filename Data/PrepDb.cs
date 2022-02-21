using Microservices_PlatformService.Data;
using Microservices_PlatformService.Models;
namespace Microservices_PlatformService.Data
{
    //Test in mem db
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());


            }
        }
        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                System.Console.WriteLine( "Seeding data....");
                context.Platforms.AddRange(new Platform() {Name="Dotnet", Publisher="M$", Cost="Free"}, 
                new Platform() {Name="SQLServer Express", Publisher="M$", Cost="Free"}, 
                new Platform() {Name="SAP B1", Publisher="SAP", Cost="Lots"},
                new Platform() {Name="Adobe CC", Publisher="Adobe", Cost="£299"}
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine( "Already have data");

            }
        }
    }
}