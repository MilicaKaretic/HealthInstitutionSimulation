using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    /// <summary>
    /// Abstract class Person that will be inherited
    /// </summary>
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
