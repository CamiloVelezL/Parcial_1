//un vendedor recibe un suelto base de $600.000. ademas recibe una comision del 10% sobre el valor total de cada venta que realiza.

//el vendedor desea saber:
//¿cuanto dinero recibira por el concepto de comisiones por las tres ventas que realiza en el mes ?
//¿cual es el total que recibira en el mes tomando en cuenta su sueldo base y comisiones ?
//¿cual fue la venta que le genero la mayor comision ?
//¿cual fue el promedio de las comisones que recibio por cada venta ?

//Ademas la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes.
// El objetivo es sumar en las 3 ventas como minimo $1.000.000 en ventas.
//Mostrar un mensaje donde se indique si gano o no el beneficio.

using System;
using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //Delcaración Datos fijos 
        decimal SueldoBase = 900000;
        decimal Comision = 10 %;
        decimal BeneficioExtra = 100000;
        decimal ObjetivoVentas = 1000000;

        //Declaracion de variable Ventas
        decimal VentaNo1;
        Console.Write("Ingrese el valor de la primera venta: ");
        VentaNo1 = Convert.ToInt32(Console.ReadLine());

        decimal VentaNo2;
        Console.Write("Ingrese el valor de la segunda venta: ");
        VentaNo2 = Convert.ToInt32(Console.ReadLine());

        decimal VentaNo3;
        Console.Write("Ingrese el valor de la tercera venta: ");
        VentaNo3 = Convert.ToInt32(Console.ReadLine());

        //comision de ventas
        decimal Comision1 = VentaNo1 * Comision;
        decimal Comision2 = VentaNo2 * Comision;
        decimal Comision3 = VentaNo3 * Comision;

        //Total de comision
        decimal TotalComision = Comision1 + Comision2 + Comision3;

        //Total a recir de suldo y comisiones
        decimal TotalaRecibir = SueldoBase + TotalComision;

        //Venta de mayor comision
        decimal VentaMayor = Math.Max(Comision1, Math.Max(Comision2, Comision3));

        //promedio de comisiones

        decimal PromedioComsiones = TotalComision / 3;

        //Analisis de Cumplimiento
        decimal TotalVentas = VentaNo1 + VentaNo2 + VentaNo3;
        Boolean ObjetivoAlcanzado = TotalVentas >= ObjetivoVentas;

        //Resultados del trabajador

        Console.WriteLine($"El total de Comsiones del mes es: {TotalComision}");
        Console.WriteLine($"El total de sueldo y Comsiones es: {TotalaRecibir}");
        Console.WriteLine($"Su mayor Comsion del mes fue: {VentaMayor}");
        Console.WriteLine($"Su promedio de Comsiones del mes fue: {PromedioComsiones}");

        if (ObjetivoAlcanzado)
        {
            Console.WriteLine($"!!!! Felicidades ¡¡¡¡ Vendio mas de 1.000.000 y recibira el beneficio extra de {BeneficioExtra}");
            TotalaRecibir += BeneficioExtra;
            Console.WriteLine($"Este mes Has Ganado en Total: {TotalaRecibir}");
        }
        else
        {
            Console.WriteLine("Este Mes no alcanzaste el Objetivo de Ventas, no tendras el beneficio Extra :( ");
        }
    }
}
