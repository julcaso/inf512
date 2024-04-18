/*****************************************************
Autor:    Profesor Julio Castro Ortiz.
Fecha:    18/4/2024.
Semestre: 2024-10.
Objetivo: Ejemplo docente.
Tema:     Asociación de clases.
Materias: INF512, INF513.
******************************************************/

using System;

// Definición de la clase Jugador
public class Jugador
{
    private string nombre;
    private int numeroCamiseta;

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string value)
    {
        nombre = value;
    }

    public int getNumeroCamiseta()
    {
        return numeroCamiseta;
    }

    public void setNumeroCamiseta(int value)
    {
        numeroCamiseta = value;
    }

    public Jugador(string nombre, int numeroCamiseta)
    {
        setNombre(nombre);
        setNumeroCamiseta(numeroCamiseta);
    }
}

// Definición de la clase Equipo
public class Equipo
{
    private string nombre;
    private Jugador[] jugadores;

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string value)
    {
        nombre = value;
    }

    public Jugador[] getJugadores()
    {
        return jugadores;
    }

    public void setJugadores(Jugador[] value)
    {
        jugadores = value;
    }

    public Equipo(string nombre, Jugador[] jugadores)
    {
        setNombre(nombre);
        setJugadores(jugadores);
    }

    public void MostrarJugadores()
    {
        Console.WriteLine("Jugadores del equipo " + getNombre() + ":");
        for (int i = 0; i < getJugadores().Length; i++)
        {
            Console.WriteLine("Nombre: " + getJugadores()[i].getNombre() + ", Número de camiseta: " + getJugadores()[i].getNumeroCamiseta());
        }
    }
}

class TesterClass
{
    static void Main()
    {
        // Crear jugadores
        Jugador jugador1 = new Jugador("Lionel Messi", 10);
        Jugador jugador2 = new Jugador("Cristiano Ronaldo", 7);

        // Crear equipo y asignar jugadores
        Jugador[] jugadores = new Jugador[] { jugador1, jugador2 };
        Equipo equipo = new Equipo("Dominicana", jugadores);

        // Mostrar los jugadores del equipo
        equipo.MostrarJugadores();
    }
}
