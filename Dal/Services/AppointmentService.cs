using Dal.Api;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class AppointmentService : IAppointment
    {
        DatabaseManager db;
        public AppointmentService(DatabaseManager db)
        {
            this.db = db;
        }
        public void Create(Appointment item)
        {
            db.Appointments.Add(item);
            db.SaveChanges();
        }

        public void Delete(Appointment item)
        {
           db.Appointments.Remove(item);
            db.SaveChanges();   
        }

        public List<Appointment> Read()
        {
            return db.Appointments.ToList();
        }

        public void Update(Appointment item)
        {
            Appointment a = db.Appointments.FirstOrDefault(a => a.Id == item.Id);
            if (a == null) return;
            a.ClientId = item.ClientId;
            a.DoctorId = item.DoctorId;
            a.TreatmentDuration = item.TreatmentDuration;
            a.Hour = item.Hour;
            a.Date = item.Date;
            db.SaveChanges();
        }

        public List<Appointment> FreeAppointment()
        {
            List<Appointment> freeAppointment= db.Appointments
                .Where(a => a.Date > DateTime.Now && a.ClientId==null).ToList();
           return freeAppointment;
        }
    }
}
