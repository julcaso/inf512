//Serie1.cs

using System;

class Serie1
{
    static double calcularFactorial (int pNumero)
    {
        double factorial = 1.0;
        if (pNumero > 0)
        {
            for (int i = 1; i <= pNumero; i++)
            {
                factorial = factorial * i;
            }
        }
        return factorial;
    }

    static void Main()
    {
        //Declaración de variables
        int n = 0;
        double x = 0.0, serie = 0.0;

        //Pantalla
        Console.Clear();

        //Entrada de datos
        Console.Write("Valor de x: ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Valor de n: ");
        n = int.Parse(Console.ReadLine());

        //Proceso
        for (int i = 0; i < n; i++)
        {
            serie += (Math.Pow(x,i) / calcularFactorial(i));
            Console.WriteLine("Ciclo {0}, Aproximación: {1} ", i, serie);
        }

        //Salida
        Console.WriteLine("Aproximación de e: {0} ", serie);
        Console.ReadLine();

    }
}
