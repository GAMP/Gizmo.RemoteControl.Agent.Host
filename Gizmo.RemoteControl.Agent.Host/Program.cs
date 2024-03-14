using Gizmo.RemoteControl.Agent.Windows;

using Microsoft.Extensions.DependencyInjection;

if (args.Length == 3)
{
    try
    {
        var services = new ServiceCollection();
        services.AddRemoteControlServices();
        var provider = services.BuildServiceProvider();
        var result = await provider.UseHeadlessClient(args[0], args[1], args[2]);

        Console.WriteLine(result);
    }
    catch
    {
        Console.WriteLine("Invalid arguments to start the agent.");
    }
}
else
{
    Console.WriteLine("Invalid arguments to start the agent.");
}

