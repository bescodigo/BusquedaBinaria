using System;

namespace BusquedaBinaria
{
    class Program
    {

        static int MarcadorMedio;
        static int valorBuscado = 86;
        static bool encontrado = false;
        

        static void Main(string[] args)
        {
           var arreglo = new int[] {0, 22, 35, 55, 60, 73, 86, 94, 100, 101 };

            Buscar(arreglo, 0, arreglo.Length-1, valorBuscado);

        }

        private static void Buscar(int[] arregloP, int Marcador1, int Marcador2, int ValorBuscado)
        {
            //  Establece indexMedio en la mitad del arreglo.
            MarcadorMedio = Marcador2 / 2;

            //  Solo es para contar las iteraciones asta que encontramos valorBuscado.
            int contador=0;

            while (encontrado == false)
            {
                
                if (arregloP[MarcadorMedio] == ValorBuscado)
                {
                    encontrado = true;
                   
                }
                //  El valor buscado se encuentra en un indice mayor al marcadorMedio??.
                else if (arregloP[MarcadorMedio] < ValorBuscado)
                {
                    
                    if(arregloP[Marcador2] == ValorBuscado)
                    {
                        MarcadorMedio = Marcador2;
                        encontrado = true;
                    }
                    else // Si el valor buscado no se encuentra en el marcador2 
                    {   //  entonces bajamos una posición.
                    
                        Marcador2--;

                        //  Y llevamos a marcador1 a la posición del marcadormedio mas uno.
                        Marcador1 = ++MarcadorMedio;
                        MarcadorMedio = (Marcador1 + Marcador2) / 2;
                    }

                }
                //  El valor buscado se encuentra en un indice menor al marcadorMedio??.
                else if (arregloP[MarcadorMedio] > ValorBuscado)
                {
                    if (arregloP[Marcador1]==ValorBuscado)
                    {
                        MarcadorMedio = Marcador1;
                        encontrado = true;
                    }
                    else // Si el valor buscado no se encuentra en el marcador1
                    {   //  entonces subimos una posición.
                    
                        Marcador1++;
                        //  Y llevamos a marcador2 a la posición del marcadormedio menos uno.
                        Marcador2 = --MarcadorMedio;
                        MarcadorMedio = (Marcador2 - Marcador1) / 2;
                    }

                }

                Console.WriteLine("Cantidad de iteraciones: "+ ++contador);
            }

            Console.WriteLine("El valor buscado es: " + ValorBuscado 
                + "\n y se encuentra en el index: " + MarcadorMedio 
                +". valor: "+ arregloP[MarcadorMedio]);
        }
    }
}
