using System;
using System.Threading.Tasks;

public class automovil
{
    private int kmph;
    private string modelo;

    public automovil(string modelo)
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

public class CarroDeCarrera : automovil
{
    private int potencia;

    public CarroDeCarrera(string modelo, int potencia) : base(modelo)
    {
        Potencia = potencia;
    }

    public int Potencia { get => potencia; set => potencia = value; }

    public void Acelerar()
    {
        base.Acelerar(Potencia);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulación de carrera de aceleración\n");

        // Crear dos carros de carrera con diferentes potencias
        CarroDeCarrera carro1 = new CarroDeCarrera("Carro 1", 50);
        CarroDeCarrera carro2 = new CarroDeCarrera("Carro 2", 75);

        Console.WriteLine("{0}: {1}", carro1.Modelo, carro1.Encender());
        Console.WriteLine("{0}: {1}", carro2.Modelo, carro2.Encender());

        Console.WriteLine("\n¡Comienza la carrera!");

        // Ejecutar la carrera de aceleración en paralelo usando la clase Parallel
        Parallel.For(0, 10, i =>
        {
            carro1.Acelerar();
            carro2.Acelerar();

            Console.WriteLine("{0}: {1} km/h", carro1.Modelo, carro1.Kmph);
            Console.WriteLine("{0}: {1} km/h", carro2.Modelo, carro2.Kmph);

            if (carro1.Kmph >= 200 || carro2.Kmph >= 200)
            {
                Console.WriteLine("\n¡La carrera ha terminado!");
                if (carro1.Kmph > carro2.Kmph)
                {
                    Console.WriteLine("El {0} es el ganador.", carro1.Modelo);
                }
                else if (carro2.Kmph > carro1.Kmph)
                {
                    Console.WriteLine("El {0} es el ganador.", carro2.Modelo);
                }
                else
                {
                    Console.WriteLine("¡Es un empate!");
                }
            }
        });

        Console.ReadKey();
    }
}
