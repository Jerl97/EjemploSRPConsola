using System;
using EjemploSRP;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Precio = 25000;
            Impuesto calcularImpuesto = new Impuesto();
            double impuesto = calcularImpuesto.ImpuestoDelIva(vehiculo.Precio);
            Console.WriteLine("El impuesto del Vehículo es {0}", impuesto);
        }
    }
}
