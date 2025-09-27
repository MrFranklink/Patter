using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
   
        interface IVehical
        {
            void ShowDetails();
        }

        internal class Car : IVehical
        {
            public void ShowDetails()
            {
                string[] st = { "Maruti", "BMW", "Prosche" };
                foreach (string s in st)
                {
                    Console.WriteLine(s);

                }
            }
        }                                                                                                                                                                                                          

        internal class Bike : IVehical
        {
            public void ShowDetails()
            {
                string[] b = { "honda", "bajaj", "Yamaha" };

                foreach (string s in b)
                {
                    Console.WriteLine(s);
                }
            }
        }

    internal class Train : IVehical
    {
        public void ShowDetails()
        {
            string[] st = { "wap-4", "wap-4", "WD" };
            foreach (string s in st)
            { Console.WriteLine(s); }
        }
    }


        internal class Factory
        {
            public IVehical GetVehical(int x)
            {
                if (x == 1 ) return new Car();
                else if (x == 2) return new Bike();
                else if (x == 3) return new Train();
                else return null;
            }



        

    }
       
}
