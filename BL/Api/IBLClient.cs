using BL.Models;
using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api;
public interface IBLClient
{
    public void SignUp(Client emp);
    public List<ViewingQueues> GetAppointmentsForClient(Client emp);
    public Client? Login(string username, string id);
    public List<ViewingQueues> GetAppointmentsBySpecialty(string specialization);
    //public List<ViewingQueues> GetAllFreeAppointments(Client client);

    }
    
