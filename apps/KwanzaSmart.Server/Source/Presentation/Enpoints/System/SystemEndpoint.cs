namespace KwanzaSmart.Server.Source.Presentation.Enpoints.System;

public class SystemEndpoint : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) =>
        app.MapGet("/", () => "KwanzaSmart")
           .WithSummary("App Name")
           .WithTags("System");
}