using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Коэффициент a не должен быть равен 0.");
            return;
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2.0 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("Корней нет");
        }
    }
}
