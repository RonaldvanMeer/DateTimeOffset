using Microsoft.AspNetCore.Mvc;

namespace DateTimeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateTimeOffsetController : ControllerBase
    {
        [HttpGet("{dateTimeOffset}")]
        public DateTimeOffset Get(DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset;
        }
    }
}