using Microsoft.AspNetCore.Mvc;
using ServiceAdviserAPI_.NetCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serviceadvisor.Data.DataModels;

namespace ServiceAdviserAPI_.NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        private readonly MaintenanceServiceService _maintenanceServiceService;
        public ServiceController(MaintenanceServiceService maintenanceServiceService)
        {
            _maintenanceServiceService = maintenanceServiceService;
        }
        [HttpGet]
        public ActionResult<List<Service>> Get() 
        {
           var services = _maintenanceServiceService.Get();
            return services;
        }
            
    }
}
