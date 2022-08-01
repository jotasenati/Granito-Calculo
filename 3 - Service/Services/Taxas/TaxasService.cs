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
        try
        {
            // BUSCANDO DADOS API
            string url = ExternalApis.ApiTaxa;
            var response = await client.GetStringAsync(url);
            var produtos = JsonConvert.DeserializeObject<double>(response);

            // RETORNO DADOS
            return produtos;
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }
    }

        public async Task<List<string>> BuscaRepoGit()
        {
            try
            {
                // ADICIONANDO URL DOS REPOSITORIOS DO GITHUB
                return new List<string>() { ExternalApis.ApiGitCalculo, ExternalApis.ApiGitTaxas };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }