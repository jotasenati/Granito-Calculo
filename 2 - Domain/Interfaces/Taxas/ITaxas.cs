using static Service.Services.Calculo.TaxasService;

namespace Domain.Interfaces.ITaxas
{
    public interface ITaxas
    {
        Task<Taxa> BuscaTaxas();
    };
}