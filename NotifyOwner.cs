using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class NotifyOwner : IPrintable
    {
        private readonly string _ownerEmail;
        public NotifyOwner(string ownerEmail)
        {
            _ownerEmail = ownerEmail;
        }
        
        public void printCommand()
        {
            Console.WriteLine($"Owner is notified . Notifying message was sent on email adress {_ownerEmail}");
        }
    }
}
