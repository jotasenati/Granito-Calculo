using Domain.Interfaces.ICalculo;
using Domain.Interfaces.ITaxas;

namespace Service.Services.Calculo;

public class CalculoService : ICalculoTaxas
{
    private readonly ITaxas _taxasService;

    public CalculoService(ITaxas taxasService) => _taxasService = taxasService;

    public Task<double> Calcula(double valorInicial, int meses)
    {
        try
        {
            //BUSCANDO A TAXA PARA CALCULO
            var taxa = _taxasService.BuscaTaxas();

            var calcInicio = valorInicial * (1 +  taxa.Result);

            //RETORNANDO E FAZENDO CALCULO DE TAXAS
            return Task.Run(() => Math.Pow(calcInicio, meses));
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