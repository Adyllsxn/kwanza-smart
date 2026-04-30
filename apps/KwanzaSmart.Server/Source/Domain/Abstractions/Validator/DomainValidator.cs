namespace KwanzaSmart.Server.Source.Domain.Abstractions.Validator;
public static class DomainValidator
{
    public static void When(bool condition, string message)
    {
        if (condition)
            throw new DomainException(message);
    }
    
    public static void NotNull(object value, string fieldName)
    {
        When(value == null, $"{fieldName} cannot be null");
    }
    
    public static void NotEmpty(string value, string fieldName)
    {
        When(string.IsNullOrWhiteSpace(value), $"{fieldName} cannot be empty");
    }
}
