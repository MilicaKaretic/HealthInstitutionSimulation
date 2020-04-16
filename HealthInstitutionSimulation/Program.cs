using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInstitutionSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.Instance;

            Doctor doctor = new Doctor("Milan");
            log.LogCreateDoctor(doctor);

            Patient patient = new Patient("Dragan");
            log.LogCreatePatient(patient);

            patient.ChooseDoctor(doctor);
            log.LogChooseDoctor(patient);

            ScheduleExamination sheduleEx = new ScheduleExamination();

            BloodSugarLevel bs = new BloodSugarLevel();
            BloodPressure bp = new BloodPressure();

            sheduleEx.Schedule(bs, patient, doctor);
            log.LogScheduleExamination(bs);

            sheduleEx.Schedule(bp, patient, doctor);
            log.LogScheduleExamination(bp);

            sheduleEx.DoTest(bs, patient, doctor);
            log.LogPerform(bs);
            log.LogTestResult(bs);

            sheduleEx.DoTest(bp, patient, doctor);
            log.LogPerform(bp);
            log.LogTestResult(bp);

            Console.ReadKey();
        }
    }
}
