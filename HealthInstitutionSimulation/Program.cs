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
            //single logger instance
            Logger log = Logger.Instance;

            //new doctor
            Doctor doctor = new Doctor("Milan");
            log.LogCreateDoctor(doctor);

            //new patient
            Patient patient = new Patient("Dragan");
            log.LogCreatePatient(patient);

            //patient choose doctor
            patient.ChooseDoctor(doctor);
            log.LogChooseDoctor(patient);

            HealthInstitution health = new HealthInstitution();

            LaboratoryExamination bs = new BloodSugarLevel();
            LaboratoryExamination bp = new BloodPressure();

            health.addLab(bs);
            health.addLab(bp);

            //doctor shedule blood sugar examination for patient
            health.Schedule(bs, patient, doctor);
            log.LogScheduleExamination(bs);

            //doctor shedule blood pressure examination for patient
            health.Schedule(bp, patient, doctor);
            log.LogScheduleExamination(bp);

            //performing blood sugar examination
            health.PerformExamination(bs, patient);
            log.LogPerform(bs);
            log.LogTestResult(bs);

            //performing blood pressure examination
            health.PerformExamination(bp, patient);
            log.LogPerform(bp);
            log.LogTestResult(bp);

            //show added examinations
            //List<LaboratoryExamination> list =  health.getAllExaminations();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i].Name);
            //}
            Console.ReadKey();
        }
    }
}
