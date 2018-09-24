using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EJERCICIO_COLA2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ///Crea un programa que pida frases al usuario, hasta que introduzca una frase vacia.
            ///En ese momento mostrara todas las ,frases ingresadas

            string frase;
            int cont = 0;

            Queue miCola = new Queue();  // genera la cola de nombre miCola y la inicia como cola

            do
            {
                System.Console.WriteLine("ingrese la frase: ");
                frase = System.Convert.ToString(System.Console.ReadLine());
                miCola.Enqueue(frase);
                cont = cont + 1;
            }
            while (frase != " ");

            System.Console.WriteLine("LOS VALORES INGRESADOS SON: ");

            for (byte i = 0; i < cont + 1; i++) // arma el buclne para recorrer la cola
            {
                frase = (string)miCola.Dequeue(); // desencola la cola con Dequeue
                Console.WriteLine(frase);         // imprime por pantalla

            }
            Console.ReadKey();

        }
    }



}
