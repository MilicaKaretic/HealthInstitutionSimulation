using System;
using System.IO;

namespace HealthInstitutionSimulation
{
    class Logger
    {
        //impelementing Singleton design pattern
        private static Logger _instance;

        private string loc;

        private Logger()  // Constructor as Private
        {
            loc = @"..\..\Log.txt";
        }

        /// <summary>
        /// Method that returns logger instance, if it's null creates new and returns it, if it's not null
        /// just returns that instance because that means that there already is one logger instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Logger();

                return _instance;
            }
        }

        /// <summary>
        /// Log for choosing doctor
        /// </summary>
        /// <param name="patient">Patient</param>
        internal void LogChooseDoctor(Patient patient)
        {
            try
            {
                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(@"[{0}] Patient '{1}' choosed doctor '{2}'", DateTime.Now, patient.Name, patient.Doctor.Name);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Log creating new patient
        /// </summary>
        /// <param name="person">Patient</param>
        internal void LogCreatePatient(Patient person)
        {
            try
            {             
                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(@"[{0}] Patient created '{1}'", DateTime.Now, person.Name);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Log create new doctor
        /// </summary>
        /// <param name="person">Doctor</param>
        public void LogCreateDoctor(Doctor person)
        {
            try
            {

                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(@"[{0}] Doctor created '{1}'", DateTime.Now, person.Name);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Log schedule examination
        /// </summary>
        /// <param name="lab">Laboratiory examination for logging</param>
        public void LogScheduleExamination(LaboratoryExamination lab)
        {
            try
            {
                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(@"[{0}] Doctor '{1}' has scheduled examination '{2}' for patient '{3}'", lab.DateAndTime, lab.Patient.Doctor.Name, lab.Name,lab.Patient.Name);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Log permorming examination
        /// </summary>
        /// <param name="lab">Performed laboratory examination</param>
        public void LogPerform(LaboratoryExamination lab)
        {
            try
            {
                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(@"[{0}] Patient '{1}' performed examination '{2}'", lab.DateAndTime, lab.Patient.Name, lab.Name);
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Log examination results
        /// </summary>
        /// <param name="lab">Laboratory examination type</param>
        public void LogTestResult(LaboratoryExamination lab)
        {
            try
            {
                StreamWriter sw = File.AppendText(loc);
                sw.WriteLine(lab.GetResults());
                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
