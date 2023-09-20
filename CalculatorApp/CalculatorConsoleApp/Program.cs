using CalculatorMachine;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Aplikasi Calculator Versi Console";

        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        var calc = new Calculator();

        Console.WriteLine();
        Console.WriteLine("Hasil pengurangan: {0} - {1} = {2}", a, b, calc.Pengurangan(a, b));
        Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", a, b, calc.Penambahan(a, b));
        Console.WriteLine("Hasil perkalian: {0} * {1} = {2}", a, b, calc.Perkalian(a, b));
        Console.WriteLine("Hasil pembagian: {0} / {1} = {2}", a, b, calc.Pembagian(a, b));
        Console.WriteLine("Hasil pangkat: {0} ^ {1} = {2}", a, b, calc.Pangkat(a, b));
        Console.WriteLine("Hasil modulo: {0} % {1} = {2}", a, b, calc.Modulo(a, b));
        Console.ReadKey();
    }
}