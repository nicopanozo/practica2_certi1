using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;

namespace Practica2_Certi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        public PatientController()
        {
            
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            PatientManager patientManager = new PatientManager();
            return Ok(patientManager.GetPatients());
        }
    }
}
