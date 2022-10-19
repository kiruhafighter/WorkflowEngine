using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name of the video :");
            string videoName = Console.ReadLine();
            var workF = new WorkFlow(new Upload(videoName));
            workF.Run();

            Console.WriteLine();

            Console.WriteLine("Write name of the WebService to encoding video");
            string webName = Console.ReadLine();
            workF = new WorkFlow(new CallWebService(videoName, webName));
            workF.Run();

            Console.WriteLine();

            Console.WriteLine("Write owner's email to notify him");
            string ownerEmail = Console.ReadLine();
            workF = new WorkFlow(new NotifyOwner(ownerEmail));
            workF.Run();

            Console.WriteLine();

        Esac1:
            Console.WriteLine("Write true for updating DataBase");
            string chose = Console.ReadLine();
            switch (chose)
            {
                case "true":
                    {
                        workF = new WorkFlow(new ChangeStatus());
                        workF.Run();
                    }
                    break;
                case "True":
                    {
                        workF = new WorkFlow(new ChangeStatus());
                        workF.Run();
                    }
                    break;
                case "False":
                    {
                        Console.WriteLine("Ok, goodbye");
                    }
                    break;
                case "false":
                    {
                        Console.WriteLine("Ok, goodbye");
                    }
                    break;
                default:
                    {
                        goto Esac1;
                    }
                    break;

            }
            
        }
    }
}
