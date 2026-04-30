namespace KwanzaSmart.Server.Source.Domain.Entities;

public sealed class ComandoEntity : EntityBase
{
    #region Properties
    public TipoComando Tipo { get; private set; }
    public AcaoComando Acao { get; private set; }
    public DateTime Timestamp { get; private set; }
    public string ExecutadoPor { get; private set; } = string.Empty;
    #endregion

    #region Constructors
    private ComandoEntity() { }

    public ComandoEntity(TipoComando tipo, AcaoComando acao, string executadoPor = "Manual")
    {
        Validate(executadoPor);
        
        Tipo = tipo;
        Acao = acao;
        ExecutadoPor = executadoPor;
        Timestamp = DateTime.UtcNow;
    }
    #endregion

    #region Private Methods
    private void Validate(string executadoPor)
    {
        DomainValidator.NotEmpty(executadoPor, "Executed by");
        DomainValidator.When(executadoPor.Length > 50, "Executed by cannot exceed 50 characters");
    }
    #endregion
}