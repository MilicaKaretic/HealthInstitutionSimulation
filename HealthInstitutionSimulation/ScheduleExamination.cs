using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class ScheduleExamination
    {
        public void Schedule(LaboratoryExamination lab, Patient patient, Doctor doctor)
        {
            lab.ScheduleLabTest(DateTime.Now, doctor, patient);
        }

        public void DoTest(LaboratoryExamination lab, Patient patient, Doctor doctor)
        {
            lab.ConductLabTest();
        }
    }
}
