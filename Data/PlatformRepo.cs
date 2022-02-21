using System;
using System.Collections.Generic;
using System.Linq;
using Microservices_PlatformService.Data;
using Microservices_PlatformService.Models;

namespace Microservices_PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }


        public void CreatePlatform(Platform plat)
        {
            if(plat == null)
            {
                throw new ArgumentNullException(nameof(plat)); 
            }

            _context.Platforms.Add(plat);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return (_context.Platforms.ToList());
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.ID == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0); //something that's changed. Any unsaved operation needs this called
        }


    }
}