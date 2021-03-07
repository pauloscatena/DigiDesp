using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiDesp.Drivers.Application.Dto;
using DigiDesp.Drivers.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DigiDesp.Drivers.Api.Controllers
{
    public class DriverController : Controller
    {
        private readonly IDriverApplication _driverApplication;
        public DriverController(IDriverApplication driverApplication)
        {
            _driverApplication = driverApplication;
        }
        
        [HttpPost]
        public async Task<IActionResult> RegisterDriverAsync(DriverDto driver)
        {
            await _driverApplication.RegisterDriver(driver);
            return Ok(driver);
        }
    }
}