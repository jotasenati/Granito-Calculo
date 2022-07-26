using Domain.Interfaces.ITaxas;
using Flurl.Http;
using Granito_Calculo.ExternalApis.ApiTaxas;

namespace Service.Services.Calculo;

public class TaxasService : ITaxas
{
    public async Task<Taxa> BuscaTaxas()
    {
        return await ApiTaxas.ApiKey.GetJsonAsync<Taxa>();
    }

    public class Taxa
    {
        public double taxa {get;set;}
    }
}