using System.Collections.Generic;
using Microservices_PlatformService.Models;
namespace Microservices_PlatformService.Data

{
    public interface IPlatformRepo
    {
         bool SaveChanges();
         IEnumerable<Platform>GetAllPlatforms();
         Platform GetPlatformById(int id);
         void CreatePlatform(Platform plat);


    }
}