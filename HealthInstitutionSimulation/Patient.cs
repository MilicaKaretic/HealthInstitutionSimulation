using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class Patient : Person
    {
        public string JMBG { get; set; }
        public int HealthRecordNumber { get; set; }
        public Doctor Doctor { get; set; }
        public List<LaboratoryExamination> Examinations { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Patient()
        {
                
        }

        /// <summary>
        /// Constructor for creating new patient with specific name
        /// </summary>
        /// <param name="name">Name</param>
        public Patient(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Method for choosing doctor for patient
        /// </summary>
        /// <param name="doctor">Doctor</param>
        internal void ChooseDoctor(Doctor doctor)
        {
            this.Doctor = doctor;
        }

       
    }
}
