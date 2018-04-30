using System;
using System.Collections.Generic;

namespace SimulacionDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializo los dados

            int[] lista = new int[] {0,0,0,0,0,0};
            int cantrand;
            Random rand = new Random();
            double random = 0;
            int max = 0;
            int num = 0;
         

         Console.Write("Ingrese cantidad de números a generar: ");
            int.TryParse(Console.ReadLine(), out cantrand);

            for (int i = 0; i < cantrand;i++){
                random = rand.NextDouble();
                if(random>=0&&random<=0.166666){
                    lista[0]++;
                } else if(random >= 0.166667 && random <= 0.333333){
                    lista[1]++;
                } else if(random >= 0.333334 && random <= 0.5){
                    lista[2]++;
                } else if(random >= 0.500001 && random <= 0.666666){
                    lista[3]++;
                } else if(random >= 0.666667 && random <= 0.833333){
                    lista[4]++;
                } else if(random >= 0.833334 && random <= 1){
                    lista[5]++;
                }
            }


            for (int i = 0; i < 6;i++){
                if(lista[i]>max){
                    max = lista[i];
                    num = (i + 1);
                }
                Console.WriteLine("El número " + (i + 1) + " apareció " + lista[i] + " veces.");
            }

            Console.WriteLine("El número que más apareció fue el " + num + " con " + max + " apariciones.");
           
            Console.ReadKey();
        }
    }
}
