namespace PrimerParcialTema2.consola
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            double altura, area, lado, volumen;
            int cantidadpiramides;
            bool seguir;
            seguir = true;
            cantidadpiramides = 0;
            do
            {
                Console.Write("ingrese la altura de la piramide (0 en ambos valores para terminar):");
                altura = Double.Parse(Console.ReadLine());
                Console.Write("ingrese el lado de la base de la piramide (0 en ambos valores para terminar):");
                lado = Double.Parse(Console.ReadLine());
                if (altura > 0 && lado > 0)
                {
                    area =CalcularArea(lado, altura);
                    volumen = CalcularVolumen(lado, altura);
                    cantidadpiramides ++;
                    Console.WriteLine($"el area de la piramide es {Math.Truncate(area)}");
                    Console.WriteLine($"el volumen de la piramide es {Math.Truncate(volumen)}");
                }
                else
                {
                    seguir = false;
                }
            } while (seguir);
            Console.WriteLine("Los valores deben ser positivos");
            Console.WriteLine($"Se ingresaron {cantidadpiramides} piramides");
        }

        private static double CalcularVolumen(double lado, double altura)  
        {
            double resultado;
            resultado = (Math.Pow(lado, 2) * altura) / 3;
            return resultado;
        }

        private static double CalcularArea(double lado, double altura)
        {
            double resultado;
            resultado = lado + (lado + Math.Sqrt(4 * Math.Pow(altura, 2) + Math.Pow(lado, 2)));
            return resultado;
        }
    
    }
}