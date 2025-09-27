using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{



    internal class Login
    {
        public void checkUser()
        {
            Console.WriteLine("Login the Valide Validation");
        }
    }

    internal class Search
    {
        public void searchforproject()
        {
            Console.WriteLine("Search Project Logic goes here");
        }
    }

    internal class cart
    {
        public void Addtocarts()
        {
            Console.WriteLine("Cart here");
        }
    }

    internal class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Logic Goes here");
        }
    }


    internal class Email
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email Logic goes here");
        }
    }

    

    internal class product1
    {

        Login l;
        Search s;
        cart c;
        Payment p;
       Email e;
        public product1()
        {
            l=new Login();
            s=new Search(); 
            c=new cart();
            p=new Payment();
            e = new Email();
        }
        public void buyproduct()
        {
            l.checkUser();
            s.searchforproject();
            c.Addtocarts();
            p.MakePayment();
            e.SendEmail();
        }
    }
    internal class Facade
    {


    }
}
