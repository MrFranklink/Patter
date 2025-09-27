using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{

    internal class OlderClass
    {
        public void ShowDetails(string data)
        {
            Console.WriteLine("Older Class Method Called "+ data);
        }
    }

    interface IMyInter
    {
        void ShowDetails(string data);
    }

   internal class NewClass : IMyInter
    {
        public void ShowDetails(string data)
        {
            Console.WriteLine("New Class Method Called " + data);
        }
    }
    internal class Adapter :IMyInter
    {
        OlderClass obj;

        public Adapter(OlderClass older)
        {
            this.obj = older;
        }
        public void ShowDetails(string data)
        {
            obj.ShowDetails(data);
        }
    }
}
