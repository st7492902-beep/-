using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            Doctor doc1 = new Doctor(1, "Іваненко Іван", "Терапевт");
            Doctor doc2 = new Doctor(2, "Петренко Олег", "Хірург");
            Doctor doc3 = new Doctor(3, "Сидоренко Марія", "Педіатр");

            hospital.AddDoctor(doc1);
            hospital.AddDoctor(doc2);
            hospital.AddDoctor(doc3);

            Patient pat1 = new Patient(1, "Коваленко Тарас", 30);
            Patient pat2 = new Patient(2, "Шевченко Олена", 25);
            Patient pat3 = new Patient(3, "Дмитренко Юрій", 40);
            Patient pat4 = new Patient(4, "Литвин Марина", 18);

            hospital.RegisterPatient(pat1);
            hospital.RegisterPatient(pat2);
            hospital.RegisterPatient(pat3);
            hospital.RegisterPatient(pat4);

            HospitalRoom room1 = new HospitalRoom(101, 2);
            HospitalRoom room2 = new HospitalRoom(102, 1);
            HospitalRoom room3 = new HospitalRoom(103, 3);

            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);
            hospital.CreateRoom(room3);

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 101);
            hospital.HospitalizePatient(4, 102);

            hospital.AddMedicalRecord(new MedicalRecord(pat1, doc1, DateTime.Now.AddDays(-3), "ГРВІ, постільний режим"));
            hospital.AddMedicalRecord(new MedicalRecord(pat2, doc2, DateTime.Now.AddDays(-1), "Операція з видалення апендиксу"));
            hospital.AddMedicalRecord(new MedicalRecord(pat1, doc3, DateTime.Now, "Консультація у педіатра для перевірки аналізів"));

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }

    }
}
