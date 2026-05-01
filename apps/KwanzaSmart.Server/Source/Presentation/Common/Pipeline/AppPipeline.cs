namespace KwanzaSmart.Server.Source.Presentation.Common.Pipeline;
public static class AppPipeline
{
    public static void UseAppPipelines(this WebApplication app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>(); 
        app.UseHttpsRedirection(); 
        app.UseCorsExtensions(); 
        app.UseRateLimiter();  
        app.UseUiDocExtensions(); 
        app.MapEndpoints();
        app.UseSignalRExtensions();
    }
}
