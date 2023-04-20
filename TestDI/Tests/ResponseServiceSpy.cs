using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDI.Services;

namespace Tests
{
    public class ResponseServiceSpy : IResponseService
    {
        ResponseService _service;
        public bool HasBeenCalled { get; set; }

        public ResponseServiceSpy(ResponseService service)
        {
            _service = service;
        }

        public string GetResponse(int id)
        {
            HasBeenCalled = true;
            return _service.GetResponse(id);
        }
    }
}
