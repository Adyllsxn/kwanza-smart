namespace KwanzaSmart.Server.Source.Infrastructure.Services;

public class ComandoService : IComandoService
{
    public Task<ComandoEntity> ExecutarComandoAsync(ComandoEntity comando, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<ComandoEntity> ExecutarComandoAutomaticoAsync(TipoComando tipo, AcaoComando acao, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<ComandoEntity> ExecutarComandoManualAsync(TipoComando tipo, AcaoComando acao, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<ComandoEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<ComandoEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<ComandoEntity>> GetComandosRecentesAsync(int ultimosMinutos, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<ComandoEntity>> GetPorPeriodoAsync(DateTime inicio, DateTime fim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<ComandoEntity>> GetPorTipoAsync(TipoComando tipo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<ComandoEntity?> GetUltimoComandoPorTipoAsync(TipoComando tipo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
