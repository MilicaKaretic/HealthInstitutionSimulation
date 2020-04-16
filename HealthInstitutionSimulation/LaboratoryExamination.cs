using System;

namespace HealthInstitutionSimulation
{
    /// <summary>
    /// Interface that will be implemented by different Laboratory Examinations types
    /// </summary>
    interface LaboratoryExamination
    {
        DateTime DateAndTime { get; set; }
        Patient Patient { get; set; }
        string Name { get; set; }

        /// <summary>
        /// Method that returns result of laboratory examination
        /// </summary>
        /// <returns></returns>
        string GetResults();
        /// <summary>
        /// Method for scheduling laboratory examination
        /// </summary>
        /// <param name="Schedule"></param>
        /// <param name="doc"></param>
        /// <param name="pat"></param>
        void ScheduleLabTest(DateTime Schedule, Doctor doc, Patient pat);

        /// <summary>
        /// Method for performing laboratory examination
        /// </summary>
        void PerformLabTest(Patient patient);
    }
}
