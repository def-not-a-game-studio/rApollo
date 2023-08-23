using System.Reflection;
using Login;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SuperSocket;
using SuperSocket.Command;

var host = SuperSocketHostBuilder
    .Create<ApolloCommand, ApolloPipelineFilter>()
    .UsePackageDecoder<ApolloPackageDecoder>()
    .UseCommand((options => {
        options.AddCommandAssembly(typeof(CA_LOGIN).GetTypeInfo().Assembly);
    }))
    .ConfigureLogging((hostCtx, loggingBuilder) => loggingBuilder.AddConsole())
    .Build();

await host.RunAsync();