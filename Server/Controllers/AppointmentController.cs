using BL.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        IBLAppointment Appointment;
        public AppointmentController(IBLManager bLManager)
        {
            Appointment = bLManager.BLAppointment;
        }
       
    }
}
