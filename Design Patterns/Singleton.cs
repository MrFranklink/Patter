using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal sealed class Singleton
    {

        static Singleton obj=null;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            return (obj==null) ? obj=new Singleton() : obj;
        }



        public void MyDbMethod()
        {
            Console.WriteLine("Db Method Called");
        }
    }
}
