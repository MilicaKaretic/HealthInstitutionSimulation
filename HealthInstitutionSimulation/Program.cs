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

            HealthInstitution health = new HealthInstitution();

            BloodSugarLevel bs = new BloodSugarLevel();
            BloodPressure bp = new BloodPressure();

            health.addLab(bs);
            health.addLab(bp);

            health.Schedule(bs, patient, doctor);
            log.LogScheduleExamination(bs);

            health.Schedule(bp, patient, doctor);
            log.LogScheduleExamination(bp);

            health.PerformExamination(bs, patient, doctor);
            log.LogPerform(bs);
            log.LogTestResult(bs);

            health.PerformExamination(bp, patient, doctor);
            log.LogPerform(bp);
            log.LogTestResult(bp);

            //List<LaboratoryExamination> list =  health.getAllExaminations();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].Name);
            //}
            Console.ReadKey();
        }
    }
}
