using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    /// <summary>
    /// Class that provides scheduling, performing laboratory examination
    /// </summary>
    class HealthInstitution
    {
        //Composite pattern implemented
        private List<LaboratoryExamination> labList;

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public HealthInstitution()
        {
            labList = new List<LaboratoryExamination>();
        }

        /// <summary>
        /// Add laboratory examination to examination list 
        /// </summary>
        /// <param name="lab"></param>
        public void addLab(LaboratoryExamination lab)
        {
            labList.Add(lab);
        }

        /// <summary>
        /// Removes examination from list
        /// </summary>
        /// <param name="lab"></param>
        public void removeLab(LaboratoryExamination lab)
        {
            labList.Remove(lab);
        }

        /// <summary>
        /// Get all examinations from list
        /// </summary>
        /// <returns></returns>
        public List<LaboratoryExamination> getAllExaminations()
        {
            return labList;
        }

        /// <summary>
        /// Schedule laboratory examination
        /// </summary>
        /// <param name="lab">Laboratory examination</param>
        /// <param name="patient">Patient</param>
        /// <param name="doctor">Doctor</param>
        public void Schedule(LaboratoryExamination lab, Patient patient, Doctor doctor)
        {
            lab.ScheduleLabTest(DateTime.Now, doctor, patient);
        }

        /// <summary>
        /// Perform laboratory examination
        /// </summary>
        /// <param name="lab">Laboratory examination</param>
        /// <param name="patient">Patient</param>
        /// <param name="doctor">Doctor</param>
        public void PerformExamination(LaboratoryExamination lab, Patient patient, Doctor doctor)
        {
            lab.PerformLabTest();
        }
    }
}
