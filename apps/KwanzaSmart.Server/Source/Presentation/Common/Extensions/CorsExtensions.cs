namespace KwanzaSmart.Server.Source.Presentation.Common.Extensions;
public static class CorsExtensions
{
    public static void AddCorsExtensions(this WebApplicationBuilder builder)
    {
        builder.Services.AddCors(x => x.AddPolicy(
            UrlCorsConfigs.CorsPolicyNames,
            policy => policy
                .WithOrigins(UrlCorsConfigs.Frontend)
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
        ));
    }

    public static void UseCorsExtensions(this WebApplication app)
    {
        app.UseCors(UrlCorsConfigs.CorsPolicyNames);
    }
}