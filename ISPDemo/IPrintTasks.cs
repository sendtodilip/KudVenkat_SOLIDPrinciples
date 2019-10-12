using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);
    }
}
