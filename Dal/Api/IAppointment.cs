using Dal.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    public interface IAppointment:Icurd<Appointment>
    {
        public List<Appointment> FreeAppointment();

    }
}
