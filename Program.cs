using System;

class Jugador
{
    public int Asesinatos { get; set; }
    public int Muertes { get; set; }
    public int Asistencias { get; set; }

    public Jugador(int asesinatos, int muertes, int asistencias)
    {
        Asesinatos = asesinatos;
        Muertes = muertes;
        Asistencias = asistencias;
    }

    public double CalcularKDA()
    {
        if (Muertes == 0)
            return Asesinatos + Asistencias;

        return (double)(Asesinatos + Asistencias) / Muertes;
    }

    public string Clasificacion()
    {
        double kda = CalcularKDA();

        if (kda < 1)
            return "Jugador en desarrollo";
        else if (kda < 2)
            return "Jugador promedio";
        else if (kda < 3)
            return "Buen jugador";
        else
            return "Jugador elite";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CLASIFICADOR DE RENDIMIENTO DEL JUGADOR ===\n");

        int asesinatos = PedirNumero("Ingrese el número de asesinatos: ");
        int muertes = PedirNumero("Ingrese el número de muertes: ");
        int asistencias = PedirNumero("Ingrese el número de asistencias: ");

        Jugador jugador = new Jugador(asesinatos, muertes, asistencias);

        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"KDA calculado: {jugador.CalcularKDA():F2}");
        Console.WriteLine($"Clasificación: {jugador.Clasificacion()}");
    }

    static int PedirNumero(string mensaje)
    {
        int numero;
        bool esValido;

        do
        {
            Console.Write(mensaje);
            esValido = int.TryParse(Console.ReadLine(), out numero);

            if (!esValido || numero < 0)
                Console.WriteLine("Entrada inválida. Por favor ingrese un número positivo.\n");

        } while (!esValido || numero < 0);

        return numero;
    }
}