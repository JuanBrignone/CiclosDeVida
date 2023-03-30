//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            //for (int i = 0; i <= 100000; i ++)
            //{
            //    Train train1 = new Train($"{i}");
            //    Console.WriteLine(Train.Cont);
            //}
            //La memoria se llena antes de llegar a la cantidad de iteaciones del for, 
            //por lo tanto no llega a completar el for y muestra en consola hasta el ultimo
            // valor que llego a contar.
        Train t1 = new Train ("Last Train To London");
        Train t2 = new Train ("Last Train To London");
        Train t3 = new Train ("Runaway Train");
        t1 = t2;
        t2 = t3;
        //Al hacer t1 = t2 le estas asignando los atributos(id) de t1 a t2 y viceversa, por lo tanto
        //t2 = "Last Train To London", pero al hacer t2 = t3, le estas asignando los valores de t3 a t2,
        //por lo tanto t2 = "Runaway Train".
        Console.WriteLine(t1.id + "\n" + t2.id + "\n" + t3.id);

        }
    }
}