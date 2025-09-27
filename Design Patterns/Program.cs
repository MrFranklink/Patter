using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var ob=Singleton.GetInstance();
            //var ob2=Singleton.GetInstance();
            //ob.MyDbMethod();

            //Console.WriteLine(ob.GetHashCode());
            //Console.WriteLine(ob2.GetHashCode());


            //Factory factory=new Factory();
            //  var f1 = factory.GetVehical(1);
            //  f1.ShowDetails();



            //prototype pt1 = (prototype)pt.Clone();
            //Console.WriteLine(pt1.MName);
            //Console.WriteLine(pt1.price);
            //Console.WriteLine(pt1.Company);


            //Console.WriteLine(pt.MName);
            //Console.WriteLine(pt.price);
            //Console.WriteLine(pt.Company);

            //pt1.MName = "Motorola";

            //Console.WriteLine("After \n\n\n\n");

            //Console.WriteLine(pt1.MName);
            //Console.WriteLine(pt1.price);
            //Console.WriteLine(pt1.Company);


            //Console.WriteLine(pt.MName);
            //Console.WriteLine(pt.price);
            //Console.WriteLine(pt.Company);

            //IMyInter ob=new NewClass();
            //ob.ShowDetails("Happy Weekend New one");

            //OlderClass old=new OlderClass();
            //IMyInter my=new Adapter(old);

            //my.ShowDetails("Happy Weekend");


            //Login ob=new Login();
            //ob.checkUser();

            //Search s=new Search();
            //s.searchforproject();

            //cart cart=new cart();
            //cart.Addtocarts();

            //Payment payment=new Payment();  
            //payment.MakePayment();

            //Email email=new Email();
            //email.SendEmail();
            // product1 p = new product1();
            //p.buyproduct();

            //PaymentContext context = new PaymentContext();
            //context.SetPaymentStrategy(new PayPalPayment());
            //context.Pay(500);
            //context.SetPaymentStrategy(new CreditCardPayment());
            //context.Pay(500);

            FileProccessor proccessor = new JasonProcessor();
            proccessor.DoAction();

            FileProccessor p = new xmlProcessor();
            p.DoAction();


            //processor.Connect();
            //processor.Read();
            //processor.Process();
            //processor.Close();
            //Console.WriteLine("================================");
            //xmlProcessor p= new xmlProcessor();
            //p.Connect();
            //p.Read();
            //p.Close();
            //p.Process();


        }
    }
}
