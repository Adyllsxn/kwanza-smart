var builder = DistributedApplication.CreateBuilder(args);

// Adiciona o Server (backend)
var server = builder.AddProject<Projects.KwanzaSmart_Server>("server")
    .WithExternalHttpEndpoints();

// Adiciona o Client Blazor WASM
builder.AddProject<Projects.KwanzaSmart_Client>("client")
    .WithReference(server)
    .WithExternalHttpEndpoints();

builder.Build().Run();