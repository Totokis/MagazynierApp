using System.Collections.Generic;
using System.Threading.Tasks;
using MagazynierApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MagazynierApp.Server.Controllers
{
    [Route("machines")]
    [ApiController]
    public class MachinesController: Controller
    {
        private readonly ILogger<MachinesController> logger;

        public MachinesController(ILogger<MachinesController> logger)
        {
            this.logger = logger;
        }

        Machine[] listOfMachines = { 
            new Machine{Name = "Maszyna na szynach",ImageUrl = "img/machines/D1080.png"},
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna na szynach",ImageUrl = "img/machines/D1080.png"},
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna na szynach",ImageUrl = "img/machines/D1080.png"},
            new Machine{Name = "Maszyna na szynach",ImageUrl = "img/machines/D1080.png"},
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
            new Machine{Name = "Maszyna na szynach",ImageUrl = "img/machines/D1080.png"},
            new Machine{Name = "Maszyna w Koszalinie",ImageUrl = "img/machines/D540.png"}, 
        };
        
        [HttpGet]
        public IEnumerable<Machine> Get()
        {
            return listOfMachines;
        }
    }
}
