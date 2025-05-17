using BL.Api;
using BL.Models;
using Dal.Api;
using Dal.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.models;
namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 

    public class ClientController : ControllerBase
    {
        IBLClient client;

        public ClientController(IBLManager bl) {
            client = bl.BLClient;

        }


        [HttpGet]
        [Route("myAppointments")]
        public ActionResult<List<ViewingQueues>> GetAppointmentsForClient([FromQuery] Client clientId) // שינוי לקבלת פרמטר מהשאילתא
        {
            try
            {
                var appointments = client.GetAppointmentsForClient(clientId);
                if (appointments == null || !appointments.Any())
                {
                    return NotFound("No appointments found for the specified client.");
                }
                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login([FromBody] Login login)
        {
            try
            {
                var clientData = client.Login(login.Name, login.Id);
                if (clientData == null)
                {
                    return Unauthorized("Invalid credentials.");
                }


                var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());

                return Ok(new LoginResponse { Client = clientData, Token = token });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("SignUp")]
        public ActionResult SignUp([FromBody] Client item)
        {
            try
            {
                client.SignUp(item);
                return CreatedAtAction(nameof(SignUp), new { id = item.Id }, item); // החזרת סטטוס 201 עם המידע שנוצר
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("FilterAvailableAppointmentsBySpecialty")]
        public IActionResult GetAvailableAppointments(string specialty)
        {
            var availableAppointments = client.GetAppointmentsBySpecialty(specialty);
            return Ok(availableAppointments);
        }

    }
}
