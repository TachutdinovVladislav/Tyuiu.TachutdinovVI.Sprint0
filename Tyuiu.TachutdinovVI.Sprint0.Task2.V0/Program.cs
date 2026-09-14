using System;
using Tyuiu.TachutdinovVI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TachutdinovVI.Sprint0.Task2.V0;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DataService.GetMessage("Влад"));
        Console.ReadKey();
    }
}
