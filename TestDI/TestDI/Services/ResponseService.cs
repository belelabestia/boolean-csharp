namespace TestDI.Services
{
    public class ResponseService : IResponseService
    {
        List<string> _responses;

        public ResponseService(List<string> responses)
        {
            _responses = responses;
        }

        public string GetResponse(int id)
        {
            return _responses.ElementAtOrDefault(id) ?? "No response";
        }
    }
}
