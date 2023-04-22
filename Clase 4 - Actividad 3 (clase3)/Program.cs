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

            calcular(A, B);

        }

        static void calcular(int A, int B)
        {
            int resultado = 1;
            int contador = 0;

            while (contador < B)
            {
                resultado = resultado * A;
                contador++;
            }

            Console.WriteLine("El resultado de " + A + " elevado a " + B + " es: " + resultado);
        }
    }
}
