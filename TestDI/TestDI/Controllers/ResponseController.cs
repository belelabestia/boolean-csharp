using Microsoft.AspNetCore.Mvc;
using TestDI.Services;

namespace TestDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponseController : ControllerBase
    {
        IResponseService _responseService;

        public ResponseController(IResponseService responseService)
        {
            _responseService = responseService;
        }

        [HttpGet("{id}")]
        public string GetResponse(int id)
        {
            switch (id)
            {
                case 0:
                    return "Test response 1";
                case 1:
                    return "Test response 2";
                default:
                    return "No response";
            }
            //return _responseService.GetResponse(id);
        }
    }
}