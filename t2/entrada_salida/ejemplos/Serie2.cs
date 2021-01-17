//Serie2.cs

using System;

class Serie2
{
    static void relentizadorProcesador (int pMilisegundos)
    {
         for (int j = 0; j < pMilisegundos; j++);
    }
    
    static void subrayarMensaje(string pMensaje)
    {
        for (int i = 0; i < pMensaje.Length; i++)
        {
           relentizadorProcesador(0);        
           Console.Write("-");
        }
        Console.WriteLine("\n");
    }

    static double calcularFactorial(int pNumero)
    {
        double factorial = 1.0;
        
        if (pNumero > 0)
        {
            for (int i=1; i <= pNumero; i++)
            {
                factorial *= i;
            }
        }

        return factorial;

    }

    static void Main()
    {
        //Declaracion de variables
        string mensaje = "Programa para calcular la serie de aproximacion de e.";
        int n = 0;
        double x=0.0, serie = 0.0;

        //Pantalla
        Console.Clear();
        Console.WriteLine(mensaje);
        subrayarMensaje(mensaje);

        //Entrada
        Console.Write("Introduzca valor de x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Introduzca valor de n: ");
        n = int.Parse(Console.ReadLine());

        //Proceso
        for (int i = 0; i < n ; i++)
        {
            serie += (Math.Pow(x,i) / calcularFactorial(i));
            Console.WriteLine("Ciclo {0}, Aproximación: {1}", i, serie);
        }

        //Salida
        Console.WriteLine("Aproximación del valor de e: {0}", serie);
        Console.ReadLine();
    }
}
