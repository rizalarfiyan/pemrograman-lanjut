using CalculatorMachine;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Demo Unit Testing Menggunakan App Console";

        var calc = new Calculator();

        Console.WriteLine();
        Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", 2, 3, calc.Penambahan(2, 3));
        Console.WriteLine("Hasil pengurangan: {0} - {1} = {2}", 7, 3, calc.Pengurangan(7, 3));
        Console.WriteLine("Hasil perkalian: {0} * {1} = {2}", 5, 2, calc.Perkalian(5, 2));
        Console.WriteLine("Hasil pembagian: {0} / {1} = {2}", 6, 2, calc.Pembagian(6, 2));
        Console.ReadKey();
    }
}