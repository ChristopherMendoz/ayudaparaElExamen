using System;
using System.Reflection;
using System.Threading.Tasks;

public class AutoDeCarrera : Automovil
{

    private double tiempoDeReaccion;
    private double tiempoDeCambioDeMarcha;
    private Random random = new Random();

    public AutoDeCarrera(string modelo) : base(modelo)
    {
        tiempoDeReaccion = random.NextDouble() * 0.5 + 0.5;
        tiempoDeCambioDeMarcha = random.NextDouble() * 0.5 + 0.5;
    }

    public void Correr()
    {
        Console.WriteLine("El auto {0} está listo para correr.", Modelo);
        Console.WriteLine("Tiempo de reacción: {0:F2} segundos", tiempoDeReaccion);
        Console.WriteLine("Tiempo de cambio de marcha: {0:F2} segundos", tiempoDeCambioDeMarcha);

        Console.WriteLine("¡En sus marcas, listos, fuera!");

        double tiempoTotal = 0;
        int velocidad = 0;

        // Simula el tiempo de reacción del conductor
        Task.Delay((int)(tiempoDeReaccion * 1000)).Wait();

        // Acelera el auto
        Parallel.For(0, 100, i =>
        {
            velocidad += i;
            Task.Delay(10).Wait();
        });

        // Simula el tiempo de cambio de marcha
        Task.Delay((int)(tiempoDeCambioDeMarcha * 1000)).Wait();

        // Acelera el auto a máxima velocidad
        Parallel.For(0, 100, i =>
        {
            velocidad += i;
            Task.Delay(5).Wait();
        });

        Console.WriteLine("El auto {0} ha cruzado la línea de meta en {1:F2} segundos.", Modelo, tiempoTotal);
    }
}


public class Program
{
    public static void Main()
    {
        AutoDeCarrera auto1 = new AutoDeCarrera("Mustang");
        AutoDeCarrera auto2 = new AutoDeCarrera("Camaro");

        Parallel.Invoke(auto1.Correr, auto2.Correr);

        Console.WriteLine("La carrera ha terminado.");
        Console.ReadLine();
    }
}


public class Automovil
{
    private int kmph;
    private string modelo;

    public Automovil(string modelo)
    {
        Modelo = modelo;
        Kmph = 0;
    }

    public string Encender()
    {
        return string.Format("El auto {0} ha sido encendido", Modelo);
    }

    public void Acelerar(int valor)
    {
        Kmph = Kmph + valor;
    }

    public void Desacelerar(int valor)
    {
        Kmph = Kmph - valor;
    }

    public int Kmph { get => kmph; set => kmph = value; }
    public string Modelo { get => modelo; set => modelo = value; }
}
