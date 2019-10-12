using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.Clients
{
    class HPLaserJet : IPrintTasks
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax");
            return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy");
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print");
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan");
            return true;
        }
    }
}
