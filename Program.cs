using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {// tehdään hienoja viivoja ja niiden sisään kohteet
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Ympyrän pinta-ala");
            Console.WriteLine("2. Nelikulmion pinta-ala");
            Console.WriteLine("3. Kolmion pinta-ala");
            Console.WriteLine("4. Lopeta");
            Console.WriteLine("-----------------------------------");
            Console.Write("Valitse laskettava pinta-ala (1-4): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {// tehdään valintoja
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    Console.WriteLine("Ohjelma päättyy.");
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void CalculateCircleArea()
    {// ympyrä säde
        Console.Write("Anna ympyrän säde: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;
     // pinta-ala
        Console.WriteLine("Ympyrän pinta-ala on: " + area);
    }

    static void CalculateRectangleArea()
    {// nelikulmion leveys
        Console.Write("Anna nelikulmion leveys: ");
        double width = Convert.ToDouble(Console.ReadLine());
     // korkeus
        Console.Write("Anna nelikulmion korkeus: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = width * height;
     // pinta-ala
        Console.WriteLine("Nelikulmion pinta-ala on: " + area);
    }

    static void CalculateTriangleArea()
    {// kolmion kanta
        Console.Write("Anna kolmion kanta: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());
     // kolmion korkeus
        Console.Write("Anna kolmion korkeus: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseLength * height;
     // kolmion pinta-ala
        Console.WriteLine("Kolmion pinta-ala on: " + area);
    }
}
