namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor Base ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de la Potencia ");
            int B = int.Parse(Console.ReadLine());

            int resultado = calcular(A, B);

            Console.WriteLine("El resultado de " + A + " elevado a " + B + " es: " + resultado);
        }

        static int calcular(int A, int B)
        {
            int resultado = 1;
            int contador = 0;

            while (contador < B)
            {
                resultado = resultado * A;
                contador++;
            }

            return resultado;
        }
    }
}
