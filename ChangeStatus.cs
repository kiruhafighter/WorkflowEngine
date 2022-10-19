using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class ChangeStatus : IPrintable
    {
        private DbSQL dbStatus;

        public ChangeStatus()
        {
            dbStatus = new DbSQL();
        }

        public void printCommand()
        {
            dbStatus.Status = "Loading";
            Console.WriteLine($"Uploading changes to the DataBase has status : {dbStatus.Status}");
            System.Threading.Thread.Sleep(4000);
            dbStatus.Status = "Updated !";
            Console.WriteLine($"Status has changed to : {dbStatus.Status}");
        }
    }
}
