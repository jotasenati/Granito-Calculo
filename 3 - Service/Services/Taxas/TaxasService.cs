using Domain.Interfaces.ITaxas;
using Flurl.Http;
using Granito_Calculo.ExternalApis.ApiTaxas;
using Newtonsoft.Json;

namespace Service.Services.Calculo;

public class TaxasService : ITaxas
{
    HttpClient client = new HttpClient();
    public async Task<double> BuscaTaxas()
    {
        string url = ApiTaxas.ApiKey;
        var response = await client.GetStringAsync(url);
        var produtos = JsonConvert.DeserializeObject<double>(response);

        return produtos;
    }

    [Serializable]
    public class Taxa
    {
        public double taxa { get; set; }
    }

    public async Task<List<string>> BuscaRepoGit()
    {
        List<string> repo = new List<string>();

        repo.Add("https://github.com/jotasenati/Granito-Taxas");
        repo.Add("https://github.com/jotasenati/Granito-Calculo");

        return repo;
    }
}