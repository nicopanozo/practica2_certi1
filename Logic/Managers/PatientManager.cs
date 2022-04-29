using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Entities;
    
namespace Logic.Managers
{
    public class PatientManager
    {
        private List<Patient> _patients;
        public PatientManager()
        {
            _patients = new List<Patient>();
            _patients.Add(new Patient() { Name = "Nicolas", LastName = "Panozo", CI = "6500000" });
            _patients.Add(new Patient() { Name = "Michael", LastName = "Jordan", CI = "4578209" });
            _patients.Add(new Patient() { Name = "Adam", LastName = "Sandler", CI = "438294" });
        }

        public List<Patient> GetPatients()
        {
            
            return _patients;
        }

        public Patient CreatePatient(string name, string lastname, string ci)
        {
            Patient createdPatient= new Patient() { Name = name, LastName = lastname, CI = ci };
            _patients.Add(createdPatient);
            return createdPatient;
        }


        

    }
}
