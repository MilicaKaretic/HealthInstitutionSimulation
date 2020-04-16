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

        public string GetResults()
        {
            return "Blood sugar results: Your previous meal was at " + LastMealTime + ". Blood sugar levels are " + Value;
        }

        public void ConductLabTest()
        {
            Value = GetRandomNumber(4.0, 5.4);            
        }

        public void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat)
        {
            DateAndTime = Schedule;
            Name = "Blood sugar";
            Patient = pat;
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
