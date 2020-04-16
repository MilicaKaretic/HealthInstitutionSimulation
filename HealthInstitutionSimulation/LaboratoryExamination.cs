using System;

namespace HealthInstitutionSimulation
{
    interface LaboratoryExamination
    {
        DateTime DateAndTime { get; set; }
        Patient Patient { get; set; }
        string Name { get; set; }

        string GetResults();
        void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat);
        void ConductLabTest();
    }
}
