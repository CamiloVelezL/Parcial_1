﻿//Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y muestre la solución.
//Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución.
//La fórmula de las soluciones es x = -b / a
using System;

internal class Program
{
    private static void Main(string[] args)

    {   
        //Ingresar valores para a y b
        Console.Write("ingrese el coeficiente para a: ");
        double a =Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el coeficiente para b: ");
        double b = Convert.ToDouble(Console.ReadLine());

    }
}