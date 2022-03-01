//HolaMundo.cs

//Declaración using.
using System;

//Declaracion de Clase en notación camellada.
class HolaMundo
{
    //El metodo main.
    static void Main()
    {
        //Declaración de variables.
        String matricula, nombre;
        
        //Mensaje que sale en pantalla.
        Console.Write("\nMatricula: ");

        //Entrada de datos con ReadLine.
        matricula = Console.ReadLine();

        Console.Write("\nNombre: ");
        nombre = Console.ReadLine();

        //Salida de datos.
        Console.WriteLine("\n*** Salida por Consola ***\n");
        Console.WriteLine("Su nombre es: \t\t" + nombre);
        Console.WriteLine("Su matricula es: \t" + matricula);
    }
}
