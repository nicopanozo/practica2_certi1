using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            List<Patient> retrievedPatients = new List<Patient>();
            retrievedPatients.Add(new Patient() { Name = "Nicolas",LastName = "Panozo", CI = "6500000" });
            retrievedPatients.Add(new Patient() { Name = "Michael",LastName = "Jordan", CI = "4578209" });
            retrievedPatients.Add(new Patient() { Name = "Adam",LastName = "Sandler", CI = "438294" });
            return Ok(retrievedPatients);
        }
    }
}
