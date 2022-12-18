class Program
{

    static void Main(string[] args)
    {
        pointintersection();
    }
    // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
    // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    //var coordinate1 = MyLibrary.Coordinate();
    //using static MyLibrary
    //var coordinate1 = Coordinate();
    //Lib.Coordinate();
    public static void pointintersection()
    {
        Console.WriteLine("Напишите координаты b1 ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите координаты k1 ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите координаты b2 ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Напишите координаты k2 ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        double y = 0;
        double x = 0;
        x = (y - b1) / k1;
        y = k2 * (y - b1) / k1 + b2;
        Console.WriteLine($"Точка пересечения по координатам :{x};{y}");
    }
}