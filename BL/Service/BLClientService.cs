using BL.Api;
using BL.Models;
using Dal.Api;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service
{
    public class BLClientService : IBLClient
    {
        Iclient dalClient;
        IAppointment dalAppointment;
        public BLClientService(IDal dal)
        {
            dalClient = dal.client;
            dalAppointment = dal.appointment;
        }
        public void SignUp(Client emp)
        {
            dalClient.Create(emp);
        }
        public Client? Login(string username, string id)

        {
            Console.WriteLine("1");
            return dalClient.GetClientById(username, id);
        }
        public List<ViewingQueues> GetAppointmentsForClient(Client client)
        {
            var appointments = client.Appointments
                .Select(a => new ViewingQueues
                {
                    Id= a.Id,
                    Date = a.Date,
                    Hour = a.Hour,
                    TreatmentDuration = a.TreatmentDuration,
                    DoctorName = a.Doctor.Name 
                }).Where(a => a.Date > DateTime.Now)
                .ToList();

            return appointments;
        }
        public List<ViewingQueues> GetAppointmentsBySpecialty(string specialization)
        {
            var allFreeAppointments = dalAppointment.FreeAppointment();

            var filteredAppointments = allFreeAppointments
                .Where(appointment =>
                    appointment.Doctor.Specialization.Equals(specialization, StringComparison.OrdinalIgnoreCase))
                .Select(appointment => new ViewingQueues
                {
                    Id = appointment.Id,
                    Date = appointment.Date,
                    Hour = appointment.Hour,
                    TreatmentDuration = appointment.TreatmentDuration,
                    DoctorName = appointment.Doctor.Name // עדכון לשם הרופא
                })
                .ToList();

            return filteredAppointments;
        }

        
    }
}

