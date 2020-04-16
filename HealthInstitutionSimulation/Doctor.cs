using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class Doctor : Person
    {
        private string Specialty { get; set; }

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Doctor()
        {

        }
        /// <summary>
        /// Constructor for creating new doctor with specific name
        /// </summary>
        /// <param name="name"></param>
        public Doctor(string name)
        {
            Name = name;
        }
    }
}
