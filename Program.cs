// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio matriz
            Console.WriteLine("Ejercicio de la matriz");
            Console.WriteLine("Matriz de:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Matriz por:");
            int b = int.Parse(Console.ReadLine());

            int[,] matriz = new int[a, b];

            hacerMatriz(matriz);

            //Ejercicio persistencia
            Console.WriteLine("Ejercicio de la persistencia");
            Console.WriteLine("Digite un numero:");
            int num = int.Parse(Console.ReadLine());

            persistencia(num);

        }

        static void hacerMatriz(int[,] matriz)
        {
            

            Console.WriteLine(matriz);

            Random numero = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    matriz[i, j] = numero.Next(1, 9);

                }
            }
            Console.WriteLine("Impresion de la matriz");
            Console.WriteLine();

            // Impresion de la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j]);
                    if (j + 1 == matriz.GetLength(1))
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(" - ");
                    }

                }

            }
            //Conteo numeros
            Console.WriteLine("Introduce el numero a buscar entre 1 y 9: ");
            int num = int.Parse(Console.ReadLine());
            
            int rep = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (num == matriz[i,j])
                    {
                        rep++;
                    }

                }

            }
             Console.WriteLine("El número: "+num +" se repite "+rep+ " veces");


            Console.WriteLine();
            /* Console.ReadKey(true); */
        }
        static void persistencia(int num)
        {
            
            int repeticiones = 0;

            Console.WriteLine("Nº inicial es: " + num);
            while (num > 9)
            {
                int producto = 1;
                while (num != 0)
                {
                    int unidades = num % 10;
                    producto *= unidades;
                    num = (num - unidades) / 10;
                }

                repeticiones++;
                Console.WriteLine("Producto " + repeticiones + "º es:" + producto);
                num = producto;
            }

            Console.WriteLine("La persistencia es: " + repeticiones + ", la cifra final: " + num);
        }
    }


}