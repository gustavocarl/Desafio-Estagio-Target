namespace Fibonacci
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe o número que será buscado na sequência de fibonacci");
            int numeroPertence = int.Parse(Console.ReadLine()!);

            if (PertenceSequenciaFibonacci(numeroPertence))
                Console.WriteLine($"O número {numeroPertence} pertence a sequência de fibonacci");
            else
                Console.WriteLine($"O número {numeroPertence} não pertence a sequência de fibonacci");
        }

        static bool PertenceSequenciaFibonacci(int numero)
        {
            if (numero == 0 || numero == 1)
                return true;

            int anterior = 0, atual = 1;

            while (atual < numero)
            {
                int proximo = anterior + atual;

                anterior = atual;

                atual = proximo;
            }

            return atual == numero;
        }
    }
}