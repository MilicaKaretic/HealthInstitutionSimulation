using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class BloodCholesterolLevel : LaboratoryExamination
    {
        public double Value { get; set; }
        public DateTime LastMeal { get; set; }
        public DateTime DateAndTime { get; set; }
        public Patient Patient { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Impelemented method from interface for test results
        /// </summary>
        /// <returns>Test result</returns>
        public string GetResults()
        {
            return "Blood cholesterol results: Your previous meal was at " + LastMeal + " and your cholesterol levels are " + Value + ".";
        }

        private Random rnd = new Random();

        /// <summary>
        /// Implemented method from iterface for performing test
        /// </summary>
        public void PerformLabTest(Patient pat)
        {
            Value = rnd.Next(0, 200);
            Patient = pat;
        }

        /// <summary>
        /// Implemented method from interface for scheduling test
        /// </summary>
        /// <param name="Schedule">Date and time</param>
        /// <param name="doc">Doctor</param>
        /// <param name="pat">Patient</param>
        public void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat)
        {
            DateAndTime = Schedule;
            Name = "Blood cholesteroll level";
            Patient = pat;
        }
    }
}
