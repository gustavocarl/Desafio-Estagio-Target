using System.Text;

namespace InverterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra a ser invertida: ");
            string palavra = Console.ReadLine()!;

            StringBuilder sb = new();

            for(var i = palavra.Length - 1; i >= 0; i--)
            {
                sb.Append(palavra[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
