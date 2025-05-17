using BL.Api;
using Dal.Api;
using Dal.models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Service;

public class BLAppointmentService:IBLAppointment
{
    IAppointment appointment;

    public BLAppointmentService(IDal dal)
    {
        this.appointment = dal.appointment; 
    }
    public bool ScheduleAppointment(int appointmentId, Client client)
    {
        //if (appointmentId == null || client == null)
        //    throw new InvalidOperationException("Data transfer error, please try again.");

        //// חפש את הפגישה על פי ה-ID
        //Appointment appointment = appointment.FirstOrDefault(a => a.Id == appointmentId);
        //if (appointment == null)
        //{
        //    throw new InvalidOperationException("Appointment not found.");
        //}

        //// עדכן את פרטי הלקוח בפגישה
        //appointment.ClientId = client.Id;

        //// שמור את השינויים במסד הנתונים
        //db.SaveChanges();

        return true; // החזר true אם הפגישה תוכננה בהצלחה
    }


    public void UpdateQueue()
    {
        throw new NotImplementedException();
    }
}
