using System;
namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            String again;
            double length;
            double width;
            double height;
            double perimeter;
            double area;
            double volume;
            double carpet;
            double cans;
            do{
                Console.WriteLine("Enter Length");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height");
                height = double.Parse(Console.ReadLine());
                perimeter = 2 * length + 2 * width;
                area = length * width;
                volume = area * height;
                carpet = area / 5;
                cans = perimeter * height / 5;
                Console.WriteLine("The area is " + area + ".");
                Console.WriteLine("The perimeter is " + perimeter + ".");
                Console.WriteLine("The volume is " + volume + ".");
                Console.WriteLine(cans + " cans of paint will be needed.");
                Console.WriteLine(carpet + " tiles of carpet will be needed");
                Console.WriteLine("Calculate another room?: y or n");
                again = Console.ReadLine();
            } while (again == "y" || again == "Y");
        }
    }
}
