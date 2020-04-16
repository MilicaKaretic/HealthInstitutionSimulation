using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class BloodPressure : LaboratoryExamination
    {
        public int UpValue { get; set; }
        public int DownValue { get; set; }
        public int Pulse { get; set; }
        public DateTime DateAndTime { get; set; }
        public Patient Patient { get ; set ; }
        public string Name { get; set; }

        private Random rnd = new Random();

        /// <summary>
        /// Impelemented method from interface for test results
        /// </summary>
        /// <returns>Test result</returns>
        public string GetResults()
        {
            return "Blood pressure results: Upper pressure: " + UpValue + ", lower pressure: " + DownValue+". Pulse: " + Pulse;
        }

        /// <summary>
        /// Implemented method from iterface for performing test
        /// </summary>
        public void PerformLabTest(Patient pat)
        {
            UpValue = rnd.Next(90, 120);
            DownValue = rnd.Next(60, 80);
            Pulse = rnd.Next(60, 100);
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
            Patient = pat;
            Name = "Blood pressure";
        }
    }
}
