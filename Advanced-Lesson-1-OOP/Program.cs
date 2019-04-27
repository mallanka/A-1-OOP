using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson.AbstractionShapeExample();
            //Lesson.OverloadingExample();
            //Lesson.InheritanceTransportExample();

            Practice.A_L1_P1_OOP();                         //A.L1.P1/6. Square Matrix

            //Practice.A_L1_P7_OperatorsOverloading();

            Transport firsTransport = new Transport();
            firsTransport.Height = 25;
            firsTransport.Length = 4;
            Transport secondTransport = new Transport();
            secondTransport.Length = 2;
            secondTransport.Height = 50;
            Console.WriteLine(firsTransport != secondTransport ? "first not equal to second" : "first equal to second");

            Console.ReadKey();
        }
    }
}
