using System;
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
            var result = iterar();
            
            MayorQueUno();
        }

        static bool iterar()
        {
            foreach (var i in Iterator())
            {
                //El break rompería la iteración del yield
                if (i == 0) return false;
            }
            return true;
        }

        static void MayorQueUno()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Where recibe un tipo de dato "T" y devuelve un booleano => "Fun<"T", bool> predicate"    
            var bt1 = numbers.Where(Predicate);
            //Has que no se haga un "foreach" (iteración) no se ejecuta el Where de manera que entregue la condición establecida
            //en la función Predicate(int)
            foreach(var value in bt1) { }
            
        }

        static IEnumerable<int> Iterator()
        {
            for(var i = 0; i < 100; i++)
            {
                //yield desbloquea el método, haciendo que por cada iteración simule un "JUMP TO" a otra linea de código
                //cada vez que realice una iteración, sin ser bloqueante (tener que esperar a recorrer las 100 iteraciones)
                yield return i;
            }
        }

        //Por lo que Predicate debe recibir dicho tipo de dato "T" y recibir el booleano
        static bool Predicate(int value)
        {
            return value > 1;
        } 
    }
}
