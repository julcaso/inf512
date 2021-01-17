//Factorial2.cs
using System;

class Factorial2
{
    static void subrayarMensaje(string pMensaje)
    {
        for (int i=0; i < pMensaje.Length; i++)
        {
            Console.Write("-");
        }
    }

    static int calcularFactorial(int pNumero)
    {
        int factorial = 1;
        for (int i=1; i<=pNumero; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
    
    static void Main()
    {
        //Declaracion de variables
        string mensaje = "Programa que calcula el factorial de un numero";
        int numero = 0, factorial = 1;

        //Pantalla
        Console.Clear();
        Console.WriteLine(mensaje);
        subrayarMensaje(mensaje);
        
        //Entrada de Datos
        Console.Write ("\nIntroduzca numero para calcular el factorial: ");
        numero = int.Parse(Console.ReadLine());

        //Proceso
        factorial = calcularFactorial(numero);
        
        //Salida
        Console.WriteLine("El factorial del número {0} es {1}", numero, factorial);
        Console.ReadLine();
    }
}
