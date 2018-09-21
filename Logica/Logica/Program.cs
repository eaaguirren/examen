using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                //Definicion de variables
                int[] Positions;
                int entrada;
                int filas, columnas;
                string[] chars = { "R", "D", "L", "U" };

                // Numero de casos
                Console.WriteLine("Provide the number of test cases (T) ");
                entrada = int.Parse(Console.ReadLine());

                //se valida restricciones
                if (entrada > 5000)
                {
                    Console.WriteLine("The maximum size is 5000.");
                    Console.ReadKey();
                }

                //se copian las posiciones para imprimir
                Positions = new int[entrada];

                int son = 0;
                while (entrada > 0)
                {

                    // se lee la fila
                    Console.WriteLine("Write Row");
                    filas = int.Parse(Console.ReadLine());

                    if (filas <= 0)
                    {
                        Console.WriteLine("The minimum size is 1 ");
                        Console.ReadKey();
                    }

                    // se lee la columna
                    Console.WriteLine("Write Column");
                    columnas = int.Parse(Console.ReadLine());



                    // calcula las posiciones
                    if (filas > columnas + 1)
                    {
                        filas = columnas + 1;
                    }
                    else if (columnas > filas)
                    {
                        columnas = filas;
                    }
                    //posicion final
                    int position = ((filas+columnas - 2) % 4);

                    Positions[son] = position;
                    son++;
                    //se valida eltamaño
                    if (entrada == son)
                        entrada = 0;
                }


                 Console.WriteLine("OutPut");
                 Console.Out.NewLine = "\r\n\r\n";
                
                foreach (var item in Positions)
                {
                    Console.WriteLine(chars[item]);
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Solo se aceptan numeros y con un maximo de 9 cifras");
                Console.ReadKey();
            }
        }
      
    }

}
