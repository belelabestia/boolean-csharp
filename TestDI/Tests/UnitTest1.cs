using TestDI.Controllers;
using TestDI.Services;

namespace Tests
{
    public class ResponseControllerTest
    {
        ResponseController _controller;
        ResponseServiceSpy _serviceSpy;

        [SetUp]
        public void Setup()
        {
            var responses = new List<string>
            {
                "Test response 1",
                "Test response 2"
            };

            var service = new ResponseService(responses);
            _serviceSpy = new ResponseServiceSpy(service);

            _controller = new ResponseController(_serviceSpy);
        }

        [Test]
        public void GetResponse_Works()
        {
            var response1 = _controller.GetResponse(0);
            var response2 = _controller.GetResponse(1);
            var noResponse = _controller.GetResponse(2);

            Assert.That(response1, Is.EqualTo("Test response 1"));
            Assert.That(response2, Is.EqualTo("Test response 2"));
            Assert.That(noResponse, Is.EqualTo("No response"));
            Assert.That(_serviceSpy.HasBeenCalled, Is.True);
        }
    }
}