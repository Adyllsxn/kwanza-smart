namespace KwanzaSmart.Server.Source.Presentation.Enpoints;
public static class EndpointGroups
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoint = app.MapGroup("");

        endpoint.MapGroup("/") 
                .WithTags("Health Check"); 
                //.MapEndpoint<SystemEndpoint>(););
    }

    private static  IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint: IEndpoint
    {
        TEndpoint.MapEndpoint(app);
        return app;
    }
}
