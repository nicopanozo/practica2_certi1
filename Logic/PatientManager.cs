using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PatientManager
    {
        public List<Patient> GetPatients()
        {
            List<Patient> retrievedPatients = new List<Patient>();
            retrievedPatients.Add(new Patient() { Name = "Nicolas", LastName = "Panozo", CI = "6500000" });
            retrievedPatients.Add(new Patient() { Name = "Michael", LastName = "Jordan", CI = "4578209" });
            retrievedPatients.Add(new Patient() { Name = "Adam", LastName = "Sandler", CI = "438294" });
            return retrievedPatients;
        }
        

    }
}
