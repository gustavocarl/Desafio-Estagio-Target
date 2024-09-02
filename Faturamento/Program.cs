using Newtonsoft.Json.Linq;
/*
 * Obs:
 * a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
 * Em nenhum local foi encontrado um json ou xml disponível para ser utilizado como fonte de dados.
*/

internal class Program
{
    private static void Main()
    {
        string json = @"{
            'faturamento_diario': [
                {'dia': 1, 'valor': 1500.00},
                {'dia': 2, 'valor': 2500.00},
                {'dia': 3, 'valor': 0.00},
                {'dia': 4, 'valor': 0.00},
                {'dia': 5, 'valor': 1200.00},
                {'dia': 6, 'valor': 3000.00},
                {'dia': 7, 'valor': 4500.00}
            ]
        }";

        var faturamento = JObject.Parse(json)["faturamento_diario"]?
                            .Where(x => x["valor"]?.Value<decimal?>() > 0)
                            .Select(x => x["valor"]?.Value<decimal>())
                            .ToList();

        decimal? menorValor = faturamento!.Min();
        decimal? maiorValor = faturamento!.Max();
        decimal? media = faturamento!.Average();

        int diasAcimaMedia = faturamento!.Count(x => x > media);

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Maior valor: {maiorValor}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}