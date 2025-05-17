using BL.Api;
using Dal.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        IBLAddress address;
        public AddressController(IBLManager bl)
        {
            address = bl.BLAddress;
        }
        [HttpPost]
        [Route("CreateAndGetAddressId")]
        public ActionResult<int> CreateAndGetAddressId([FromBody] Address item)
        {
            try
            {
                int addressId = address.CreateAndGetAddressId(item);
                return Ok(addressId);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
            }
        }
    }
}
