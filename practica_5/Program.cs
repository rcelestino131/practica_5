using System;

namespace practica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Llamado a las funciones usando la nueva clase "actividad_1"
            actividad_1.MostrarCabecera();

            Console.Write("Ingrese el costo del servicio técnico: S/. ");
            double costoServicio = double.Parse(Console.ReadLine());

            // 2. Paso por Valor
            double costoConImpuesto = actividad_1.CalcularTotalConIGV(costoServicio);

            Console.WriteLine($"\nPrecio Base Original: S/. {costoServicio}");
            Console.WriteLine($"Precio con IGV (Calculado por Valor): S/. {costoConImpuesto}");

            // 3. Paso por Referencia
            double descuentoFidelidad = 15.0;
            actividad_1.AplicarDescuentoEspecial(ref costoConImpuesto, descuentoFidelidad);

            // Verificación del cambio por referencia
            Console.WriteLine($"Precio Final a Pagar (Modificado por Referencia): S/. {costoConImpuesto}");

            // 4. Cierre de programa
            actividad_1.MostrarPie();

            Console.ReadKey();
        }
    }
}