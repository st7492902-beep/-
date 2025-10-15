﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalRoom
    {

        public int RoomNumber;
        public int Capacity;
        public List<Patient> Patients;

        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>(); ;
        }

        public void AddPatient(Patient patient)
        {
            if (Patients.Count < Capacity)
            {
                Patients.Add(patient);
                Console.WriteLine($"Пацієнт {patient.Name} доданий у палату №{RoomNumber}");
            }
            else
            {
                Console.WriteLine($"Палата №{RoomNumber} переповнена! Неможливо додати пацієнта.");
            }
        }

    }
}
