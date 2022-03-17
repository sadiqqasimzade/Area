using System;
using Figure.Models;
namespace Figure
{
    public class Program
    {
        static void Main()
        {

            int choise;

            do
            {
                Console.Write(@"1. Square
2. Rectangular
0. Quit
Choise:");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 0: break;//case 0 menasi yoxdu ancaq vermesem default isleyir
                    case 1:
                        double side = 0;
                        Input(ref side);
                        Square square = new Square(side);
                        Console.WriteLine("Area=" + square.CalcArea());
                        break;
                    case 2:
                        double side1 = 0, side2 = 0;
                        Input(ref side1, ref side2);
                        Rectangular rectangular = new Rectangular(side1, side2);
                        Console.WriteLine("Area=" + rectangular.CalcArea());
                        break;
                    default:
                        Console.WriteLine("WRONG INPUT");
                        break;
                }
            } while (choise != 0);
        }
        static void Input(ref double side1)
        {
            do
            {
                Console.Write("Side:");
                side1 = Convert.ToDouble(Console.ReadLine());
                if (side1 <= 0) Console.WriteLine("WRONG INPUT");
            } while (side1 <= 0);
        }
        static void Input(ref double side1, ref double side2)
        {
            do
            {
                Console.Write("Side1:");
                side1 = Convert.ToDouble(Console.ReadLine());
                if (side1 <= 0) Console.WriteLine("WRONG INPUT");
            } while (side1 <= 0);
            do
            {
                Console.Write("Side2:");
                side2 = Convert.ToDouble(Console.ReadLine());
                if (side2 <= 0) Console.WriteLine("WRONG INPUT");
            } while (side2 <= 0);
        }
    }
}
