using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{

    abstract class FileProccessor
    {
        public void DoAction()
        {
            Connect();
            Read();
            Process();
            Close();
        }


        public abstract void Connect();
        public abstract void Read();
        public  void Process()
        {
            Console.WriteLine("Process the File");
        }
        public abstract void Close();

    }

    internal class JasonProcessor:FileProccessor
    {
        public override void Connect()
        {
            Console.WriteLine("Connect to Xml File.. ");
        }

        public override void Read()
        {
            Console.WriteLine("Read From Xml File");
        }

       

        public override void Close()
        {
            Console.WriteLine("close the json file");
        }
    }


    internal class xmlProcessor:FileProccessor
    {
        public override void Connect()
        {
            Console.WriteLine("Connect to Xml File.. ");
        }

        public override void Read()
        {
            Console.WriteLine("Read From Xml File");
        }

       

        public override void Close()
        {
            Console.WriteLine("close the xml file");
        }
    }
    internal class Templete
    {
    }
}
