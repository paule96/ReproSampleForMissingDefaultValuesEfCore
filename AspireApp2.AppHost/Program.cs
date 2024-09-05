var builder = DistributedApplication.CreateBuilder(args);

var dbServer = builder.AddPostgres("db-server").WithHealthCheck();

dbServer.WithPgAdmin(c => c.WithHostPort(5050).WaitFor(dbServer));

var apiService = builder.AddProject<Projects.AspireApp2_ApiService>("apiservice")
    .WaitFor(dbServer);

builder.AddProject<Projects.AspireApp2_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
