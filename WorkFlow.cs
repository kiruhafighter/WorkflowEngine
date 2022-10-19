using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlow
    {
        private readonly IPrintable _iprint;
        public WorkFlow(IPrintable Iprint)
        {
            _iprint = Iprint;
        }

        public void Run()
        {
            _iprint.printCommand();
        }
    }
}
