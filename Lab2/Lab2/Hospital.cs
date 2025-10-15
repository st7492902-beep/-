﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Hospital
    {

        public List<Doctor> Doctors;
        public List<Patient> Patients;
        public List<HospitalRoom> Rooms;
        public List<MedicalRecord> Records;

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();

        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Лікар {doctor.Name} ({doctor.Specialization}) доданий до системи");
        }

        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований");
        }

        public void CreateRoom(HospitalRoom room)
        {
            Rooms.Add(room);
            Console.WriteLine($"Палата {room.RoomNumber} створена (місткість: {room.Capacity})");
        }

        public void HospitalizePatient(int patientId, int roomNumber)
        {
            Patient patient = Patients.Find(p => p.Id == patientId);
            if (patient == null)
            {
                Console.WriteLine($"Пацієнт з ID {patientId} не знайдений!");
                return;
            }

            HospitalRoom room = Rooms.Find(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine($"Палата №{roomNumber} не знайдена!");
                return;
            }
            room.AddPatient(patient);

        }

        public void AddMedicalRecord(MedicalRecord record)
        {
            Records.Add(record);
            Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            return Records.FindAll(r => r.Patient.Id == patientId);
        }

        public string GetStatistics()
        {
            int totalPatientsInRooms = Rooms.Sum(r => r.Patients.Count);

            string result =
            $"=== СТАТИСТИКА ЛІКАРНІ ===\n" +
            $"Кількість лікарів: {Doctors.Count}\n" +
            $"Кількість зареєстрованих пацієнтів: {Patients.Count}\n" +
            $"Кількість палат: {Rooms.Count}\n" +
            $"Кількість пацієнтів у палатах: {totalPatientsInRooms}\n" +
            $"Кількість медичних записів: {Records.Count}\n";

            return result;
        }
    }
}
