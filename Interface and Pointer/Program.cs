using AbstractClass_and_Interfaces;
using System;
using System.Drawing;

namespace com.start
{
    public class MainApp
    {
        static void Main(String[] args) {
            /*   //  Console.WriteLine("today we See the Abstract class features ");
                 Engineering_Student student = new Engineering_Student(1,"Ashutosh",98);
                 payable ref1= new Engineering_Student();
                 ref1.payeable();
                 Engineering_Student std=new Engineering_Student();  
                // std.payeable();
            
            Student std = new Engineering_Student();
            std.msg();
*/
            unsafe
            {
                int a = 12;
                int* b = &a;
                *b = 9562;
                Student std = new Engineering_Student(11, "Ashutosh", 74);
                Student* str1 = &std;
                Engineering_Student std3 = new Engineering_Student(150, "Ashutosh", 74);
                std3.chekckid(str1);
                std3.printall();
             
                
            }
            int[] arr = { 12, 45, 56 };
            int[] brr = { 12, 45, 56 };

            int[] q = brr;
            
            unsafe
            {
                fixed (int* ptr = arr) { 
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            




        }
    }



}