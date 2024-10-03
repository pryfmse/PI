using System;
namespace ПИ;

class Pk
{
    public string Model { get; set; }
    public double ClockSpeed { get; set; }
    public int RamSize { get; set; }
    public int HddSize { get; set; }

    public string Info()
    {
        return $"Модель: {Model}, Тактовая частота: {ClockSpeed} ГГц, " + 
               $"ОЗУ: {RamSize} ГБ, Жесткий диск: {HddSize} ГБ, ";
    }
}

class Program
{
    static void Main()
    {
        Pk Pk1 = new()
        {
            Model = Console.ReadLine(),
            ClockSpeed = Double.Parse(Console.ReadLine()),
            RamSize = Int32.Parse(Console.ReadLine()),
            HddSize = Int32.Parse(Console.ReadLine())
        };

        Console.WriteLine(Pk1.Info());
    }
}