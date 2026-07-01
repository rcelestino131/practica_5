using System;

namespace practica_5
{
    public class actividad_1
    {
        // ---  Funciones de encabezado propias ---
        public static void MostrarCabecera()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    SISTEMA DE SOPORTE Y VENTAS TECH    ");
            Console.WriteLine("========================================");
        }

        public static void MostrarPie()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("   Fin del Proceso - Gracias por confiar");
            Console.WriteLine("========================================");
        }

        // --- Paso por Valor ---
        public static double CalcularTotalConIGV(double precioBase)
        {
            double igv = precioBase * 0.18;
            return precioBase + igv;
        }

        // --- Paso por Referencia ---
        public static void AplicarDescuentoEspecial(ref double precioFinal, double descuento)
        {
            precioFinal = precioFinal - descuento;
            Console.WriteLine($"\n[INFO] Se aplicó un descuento directo de: S/. {descuento}");
        }
    }
}