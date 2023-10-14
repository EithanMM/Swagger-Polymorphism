using Microsoft.AspNetCore.Mvc;
using swagger.polymorphism.core.Models;
using swagger.polymorphism.core.Requests;
using swagger.polymorphism.data.Services;

namespace swagger.polymorphism.service.Controllers
{
    [Route("api/v1/device")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDummyService _dummyService;
        public DeviceController(IDummyService dummyService)
        {
            _dummyService = dummyService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(Device), StatusCodes.Status201Created)]
        public IActionResult AddDevice([FromBody] DeviceRequest request)
        {
            var result = _dummyService.GenerateDeviceDummy(request);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetDevices()
        {
            return Ok(_dummyService.GetDevices());
        }
    }
}
