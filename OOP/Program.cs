using System;
namespace start
{
    class based{
       
        static void Main(String[] args)
        {
           // Console.WriteLine("my first .dot nate code");

            Employee employee = new SalseMan(1, "Ashutosh", 125);
            //  employee.print();
            String name = "Ashutosh";
            String newname = new string( "Ashutosh");
            /* if (name == newname)
             {
                 Console.WriteLine("Equals");
             }
             else
             {
                 Console.WriteLine("not Equas");
             }
             if (name.Equals(newname))
             {
                 Console.WriteLine("through equlas methos =true");
             }
             else
             {
                 Console.WriteLine("equals method sey false");
             }
            */
            SalseMan em1 = new SalseMan(1, "Ashutosh", 855);
            SalseMan em2 = new SalseMan(1, "Ashutosh", 855);
            Console.WriteLine(em1.Equals(em2)); 
            SalseMan em3 = new SalseMan();
            /*
                        if (em1 == em2)
                        {
                            Console.WriteLine("Equals");
                        }
                        else
                        {
                            Console.WriteLine("not Equas");
                        }
                        if (em1.Equals(em2))
                        {
                            Console.WriteLine("through equlas methos =true");
                        }
                        else
                        {
                            Console.WriteLine("equals method sey false");
                        }
            */
            bool res= em1 == em3;
            Console.WriteLine(res);     
        }
}

}
