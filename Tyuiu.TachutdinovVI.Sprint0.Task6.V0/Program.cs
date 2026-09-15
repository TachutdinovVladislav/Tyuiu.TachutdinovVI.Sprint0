using Tyuiu.TachutdinovVI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TachutdinovVI.Sprint0.Task6.V0;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));
        Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arraynums));
        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
        Console.ReadKey();
    }
}

