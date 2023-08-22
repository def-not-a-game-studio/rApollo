// See https://aka.ms/new-console-template for more information

using System.Net;
using Login;
using SuperSocket.Client;
var client = new EasyClient<ServerPacket>(new ServerPacketFilter()).AsClient();

if (!await client.ConnectAsync(new IPEndPoint(IPAddress.Loopback, 6900)))
{
    Console.WriteLine("Failed to connect the target server.");
    return;
}

while (true)
{
    var p = await client.ReceiveAsync();

    if (p == null) // connection dropped
        break;
                
    Console.WriteLine("received back");
}