using System.ComponentModel.DataAnnotations;

namespace Microservices_PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        //cant supply ID as platform creates ID
        [Required]
        public string Name {get;set;}
        [Required]
        public string Publisher {get;set;}
        [Required]
        public string Cost {get;set;}
    }
}