using BL.Api;
using BL.Models;
using Dal.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Server.models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 

    public class ClientController : ControllerBase
    {
        private readonly IBLClient client;
        private readonly IConfiguration _config;
        public ClientController(IBLManager bl, IConfiguration config)
        {
            client = bl.BLClient;
            _config = config;
        }
        [Authorize]
        [HttpGet]
        [Route("myAppointments")]
        public ActionResult<List<ViewingQueues>> GetAppointmentsForClient([FromQuery] Client client) 
        {
            try
            {
                var appointments = this.client.GetAppointmentsForClient(client);
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

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"])); 
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, clientData.Id),
                    new Claim(JwtRegisteredClaimNames.UniqueName, clientData.Name),
                };

                var token = new JwtSecurityToken(
                    issuer: _config["Jwt:issuer"],
                    audience: _config["Jwt:audience"],
                    claims: claims,
                    expires: DateTime.Now.AddHours(2),
                    signingCredentials: creds);

                var tokenJwt = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new LoginResponse { Client = clientData, Token = tokenJwt });
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
