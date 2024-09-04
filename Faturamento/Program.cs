using Faturamento;
using Newtonsoft.Json;

internal class Program
{
    private static void Main()
    {
        double menorValor = 0, maiorValor = 0;
        int quantidadeDeDiasComFaturamento = 0, quantidadeDeDiasComFaturamentoAcimaDaMedia = 0;
        double valorTotalDoFaturamento = 0;

        string nomeDoArquivo = "Dados.json";

        string diretorioBase = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;

        string caminhoFinal = Path.Combine(diretorioBase, nomeDoArquivo);

        using StreamReader sr = new(caminhoFinal);
        var json = sr.ReadToEnd();

        var dados = JsonConvert.DeserializeObject<List<Dados>>(json);

        for (var i = 0; i < dados!.Count; i++)
        {
            if (i == 0)
            {
                menorValor = dados[i].Valor;
                maiorValor = dados[i].Valor;
            }

            if ((menorValor > dados[i].Valor) && (dados[i].Valor > 0))
            {
                menorValor = dados[i].Valor;
            }
            else if ((maiorValor < dados[i].Valor) && (dados[i].Valor > 0))
            {
                maiorValor = dados[i].Valor;
            }

            if (dados[i].Valor > 0)
            {
                valorTotalDoFaturamento += dados[i].Valor;
                quantidadeDeDiasComFaturamento++;
            }
        }

        var mediaDoFaturamentoMensal = valorTotalDoFaturamento / quantidadeDeDiasComFaturamento;

        for (var i = 0; i < dados!.Count; i++)
        {
            if (dados[i].Valor > 0)
            {
                if (dados[i].Valor > mediaDoFaturamentoMensal)
                {
                    quantidadeDeDiasComFaturamentoAcimaDaMedia++;
                }
            }
        }

        Console.WriteLine($"Dia com menor valor de faturamento: {Math.Round(menorValor, 2)}");
        Console.WriteLine($"Dia com maior valor de faturamento: {Math.Round(maiorValor, 2)}");

        Console.WriteLine();
        Console.WriteLine($"Dias com faturamento: {quantidadeDeDiasComFaturamento}");
        Console.WriteLine($"Valor total do faturamento: {Math.Round(valorTotalDoFaturamento, 2)}");
        Console.WriteLine($"A média de faturamento no mês é: {Math.Round(mediaDoFaturamentoMensal, 2)}");

        Console.WriteLine();
        Console.WriteLine($"Quantidade de dias com faturamento acima da média é: {quantidadeDeDiasComFaturamentoAcimaDaMedia}");
    }
}