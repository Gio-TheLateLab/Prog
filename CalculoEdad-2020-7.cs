using System;

class Program {
    static void Main(string[] args) {

        Console.WriteLine("Por favor ingrese su año de nacimiento: ");
        int añoNacimiento = int.Parse(Console.ReadLine());
        int añoActual = 2020;
        int edad = añoActual - añoNacimiento;
        Console.WriteLine("Su edad es: " + edad);

    }
}
