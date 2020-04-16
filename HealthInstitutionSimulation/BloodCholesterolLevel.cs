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

        public string GetResults()
        {
            return "Blood cholesterol results: Your previous meal was at " + LastMeal + " and your cholesterol levels are " + Value + ".";
        }

        private Random rnd = new Random();
        public void ConductLabTest()
        {
            Value = rnd.Next(0, 200);
        }

        public void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat)
        {
            DateAndTime = Schedule;
            Name = "Blood cholesteroll level";
        }
    }
}
