namespace KwanzaSmart.Server.Source.Infrastructure.Services;

public class AlertaService : IAlertaService
{
    public Task AtualizarGravidadeAsync(Guid id, Gravidade novaGravidade, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<AlertaEntity> CriarAlertaAsync(AlertaEntity alerta, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExisteAlertaNaoLidoPorTipoAsync(TipoSensor tipo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> GetAlertasRecentesAsync(int ultimosMinutos, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<AlertaEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> GetNaoLidosAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> GetPorGravidadeAsync(Gravidade gravidade, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> GetPorTipoAsync(TipoSensor tipo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task MarcarComoLidaAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task MarcarTodosComoLidosAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AlertaEntity>> ProcessarRegrasAsync(LeituraSensorEntity leitura, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
