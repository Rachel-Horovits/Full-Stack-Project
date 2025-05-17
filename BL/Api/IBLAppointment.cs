using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IBLAppointment
    {
        public void UpdateQueue();
        public bool ScheduleAppointment(int id,Client client);

    }
}
