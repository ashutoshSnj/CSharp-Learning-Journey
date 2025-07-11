using System;
namespace Exception_Handlling
{
    public class MainApp
    {
        public static void Main(String[] args)
        {
          //  Console.WriteLine("Enter Age = ");
            MainApp obj=new MainApp();
         //   obj.checkAge(Convert.ToInt32(Console.ReadLine()));
            Bank acc = new Bank(1, "Ashutosh Shelke", 125.02);
            try
            {
                acc.withdrow(1250);

            }
            catch (Balance_Less exce)
            {
                Console.WriteLine(exce);
            }
        }

        public void checkAge(int age)
        {
            try
            {
                int result = 100 / age;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Age cannot be Zero");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Iam Always Exicute bro !!!!!!");
            }
           
        }
        
     


    }
}
