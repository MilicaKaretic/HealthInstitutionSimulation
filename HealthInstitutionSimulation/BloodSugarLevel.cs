using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class BloodSugarLevel : LaboratoryExamination
    {
        public double Value { get; set; }
        public DateTime LastMealTime { get; set; }
        public DateTime DateAndTime { get; set; }
        public Patient Patient { get; set; }
        public string Name { get ; set; }

        /// <summary>
        /// Impelemnted method from interface for test results
        /// </summary>
        /// <returns>Test result</returns>
        public string GetResults()
        {
            return "Blood sugar results: Your previous meal was at " + LastMealTime + ". Blood sugar levels are " + Value;
        }

        /// <summary>
        /// Implemented method from iterface for performing test
        /// </summary>
        public void PerformLabTest()
        {
            Value = GetRandomNumber(4.0, 5.4);            
        }

        /// <summary>
        /// Implemented method from interface for scheduling
        /// </summary>
        /// <param name="Schedule">Date and time</param>
        /// <param name="doc">Doctor</param>
        /// <param name="pat">Patient</param>
        public void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat)
        {
            DateAndTime = Schedule;
            Name = "Blood sugar";
            Patient = pat;
        }

        /// <summary>
        /// Get random number for value
        /// </summary>
        /// <param name="minimum">Min value</param>
        /// <param name="maximum">Max value</param>
        /// <returns>Random number</returns>
        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
