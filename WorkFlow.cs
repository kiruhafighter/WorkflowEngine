using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlow
    {
        private readonly IList<IPrintable> _iprint;
        public WorkFlow()
        {
            _iprint = new List<IPrintable>();
        }

        public void Run()
        {
            foreach(var flow in _iprint)
            {
                flow.printCommand();
            }
        }

        public void RegisterNewFlow(IPrintable flow)
        {
            _iprint.Add(flow);
        }
    }
}
