namespace Domain.Interfaces.ICalculo
{
    public interface ICalculoTaxas
    {
        Task<double> Calcula(double valorInicial, int meses);
        Task<List<string>> ShowCode();
    };
}