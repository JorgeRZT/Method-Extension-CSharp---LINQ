﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {   
        //Para ampliar conocimientos
        //Covarianca y Contravarianza en C#
        static void Main(string[] args)
        {
            MayorQueUno();
        }

        static void MayorQueUno()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Where recibe un entero y devuelve un booleano => "Fun<int, bool> predicate"    
            var bt1 = numbers.Where(Predicate);
        }

        //Por lo que Predicate debe recibir dicho entero y recibir el booleano
        static bool Predicate(int value)
        {
            return value > 1;
        } 
    }
}