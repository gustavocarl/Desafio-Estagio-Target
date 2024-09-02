namespace Faturamento_Mensal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double faturamento_sp = 67836.43;
            double faturamento_rj = 36678.66;
            double faturamento_mg = 29229.88;
            double faturamento_es = 27165.48;
            double faturamento_outros = 19849.53;

            double faturamento_total = faturamento_sp + faturamento_rj + faturamento_mg + faturamento_es + faturamento_outros;

            double porcentagem_sp = ((faturamento_sp / faturamento_total) * 100);
            double porcentagem_rj = ((faturamento_rj / faturamento_total) * 100);
            double porcentagem_mg = ((faturamento_mg / faturamento_total) * 100);
            double porcentagem_es = ((faturamento_es / faturamento_total) * 100);
            double porcentagem_outros = ((faturamento_outros / faturamento_total) * 100);

            Console.WriteLine($"O faturamento total é: {faturamento_total}");
            Console.WriteLine($"A porcentagem de SP é: {porcentagem_sp}%");
            Console.WriteLine($"A porcentagem de RJ é: {porcentagem_rj}%");
            Console.WriteLine($"A porcentagem de MG é: {porcentagem_mg}%");
            Console.WriteLine($"A porcentagem de ES é: {porcentagem_es}%");
            Console.WriteLine($"A porcentagem de Outros é: {porcentagem_outros}%");

        }
    }
}
