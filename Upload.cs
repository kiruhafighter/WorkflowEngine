using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Upload : IPrintable
    {
        private readonly string _vidos;
        public Upload(string Video)
        {
            _vidos = Video;
        }
        public void printCommand()
        {
            Console.WriteLine($"Video with name '{_vidos}' was uploaded succesfully");
        }
    }
}
