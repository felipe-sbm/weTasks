var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.weTasks>("wetasks");

builder.Build().Run();
