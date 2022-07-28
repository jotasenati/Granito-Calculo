using Domain.Interfaces.ICalculo;
using Domain.Interfaces.ITaxas;

namespace Service.Services.Calculo;

public class CalculoService : ICalculoTaxas
{
    private readonly ITaxas _taxasService;

    public CalculoService (ITaxas taxasService) => _taxasService = taxasService;

    public Task<double> Calcula(double valorInicial, int meses)
    {
        try
        {
            var taxa =  _taxasService.BuscaTaxas();

            var teste = taxa.Result;   

            var valorFinal = valorInicial * (1 +  teste) * meses;
            return Task.Run(() => 1.00);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task<List<string>> ShowCode()
    {
        return Task.Run(() => _taxasService.BuscaRepoGit()); 
    }
}