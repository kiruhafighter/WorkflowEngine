using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class CallWebService : IPrintable
    {
        public readonly string _webService;
        public readonly string _videoname;
        public CallWebService(string videoname ,string webService)
        {
            _webService = webService;
            _videoname = videoname;
        }

        public void printCommand()
        {
            Console.WriteLine($"Video with name '{_videoname}' was encoded by {_webService}");
        }

    }
}
