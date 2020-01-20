using System;

class Program
{
    static void Main() {

        // Ingreso del nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su año de nacimiento: ");
        int fecha = int.Parse(Console.ReadLine());
        int actual = 2020;
        int edad = actual - fecha;
        Console.WriteLine("Hola " + nombre + " su edad es: " + edad);


    }
}

