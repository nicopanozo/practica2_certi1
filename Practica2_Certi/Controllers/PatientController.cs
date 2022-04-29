using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic.Managers;
using Logic.Entities;

namespace Practica2_Certi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        public PatientController()
        {
            //Darle Http methods, GET, POST, PUT, DELETE
            
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            PatientManager patientManager = new PatientManager();
            return Ok(patientManager.GetPatients());
        }

        [HttpPost]
        public IActionResult CreatePatients()
        {
            PatientManager patientManager = new PatientManager();
            return Ok(patientManager.GetPatients());
        }
        [HttpPut]
        public IActionResult UpdatePatients()
        {
            PatientManager patientManager = new PatientManager();
            return Ok(patientManager.GetPatients());
        }
        [HttpDelete]
        public IActionResult DeletePatients()
        {
            PatientManager patientManager = new PatientManager();
            return Ok(patientManager.GetPatients());
        }
    }
}
