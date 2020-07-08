using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Ingrese X en radianes: ");
            double x = double.Parse(Console.ReadLine());
            double xGrados = x * (180.0 / Math.PI);
            Console.WriteLine("El equivalente de X en grados es: " + xGrados);
        }
    }
}
