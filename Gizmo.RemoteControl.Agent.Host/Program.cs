using Gizmo.RemoteControl.Agent.Windows;

using Microsoft.Extensions.DependencyInjection;

var host = "http://localhost:81";
var clientId = "695468c9-93f7-47ea-8622-85495b2e04f9";
var accessKey = "password";

if (args.Length > 0)
{
    try
    {
        host = args[0];
        clientId = args[1];
        accessKey = args[2];
    }
    catch
    {
        Console.WriteLine("Invalid arguments to start the agent.");
        return;
    }
}

var services = new ServiceCollection();
services.AddRemoteControlServices();
var provider = services.BuildServiceProvider();
var result = await provider.UseHeadlessClient(host, clientId, accessKey);

Console.WriteLine(result);
