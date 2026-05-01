namespace KwanzaSmart.Server.Source.Infrastructure.Services;
public class LeituraSensorService : ILeituraSensorService
{
    public Task<bool> DeleteLeituraAntigaAsync(DateTime cutoff, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<LeituraSensorEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<LeituraSensorEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<LeituraSensorEntity>> GetHistoricoAsync(int ultimosMinutos, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetMediaPhAsync(DateTime inicio, DateTime fim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetMediaTemperaturaAsync(DateTime inicio, DateTime fim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<LeituraSensorEntity>> GetPorPeriodoAsync(DateTime inicio, DateTime fim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<LeituraSensorEntity?> GetUltimaLeituraAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<LeituraSensorEntity> RegistrarLeituraAsync(LeituraSensorEntity leitura, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task RegistrarLeiturasEmLoteAsync(IEnumerable<LeituraSensorEntity> leituras, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
