using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        static Random random = new Random();
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()                                //A.L1.P1/6. Square Matrix
        {
            int[,] areaMatrix = new int[10, 3];
            for (int i = 0; i < 10; i++)            //Circle column
            {
                areaMatrix[i, 0] = (new Circle(random.Next(1,11))).Draw();
            }

            for (int i = 0; i < 10; i++)            //rectangle column
            {
                areaMatrix[i, 1] = (new Rectangle(
                    random.Next(1, 11), 
                    random.Next(1, 11))).Draw();
            }

            for (int i = 0; i < 10; i++)            //triangle column
            {
                areaMatrix[i, 2] = (new Triangle(
                    random.Next(1, 11), 
                    random.Next(1, 11))).Draw();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(areaMatrix[j,i]+" ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
            
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {
        }
    }
}
