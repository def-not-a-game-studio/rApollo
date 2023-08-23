﻿// See https://aka.ms/new-console-template for more information

using System.Net;
using Domain;
using Login;
using MemoryPack;
using SuperSocket.Client;
var client = new EasyClient<ServerPacket>(new ServerPacketFilter()).AsClient();

if (!await client.ConnectAsync(new IPEndPoint(IPAddress.Loopback, 6900)))
{
    Console.WriteLine("Failed to connect the target server.");
    return;
}

var v = new CaLoginPacket() {
    Header = (short)PacketHeader.CA_LOGIN,
    Login = "danilo"
};
var bin = MemoryPackSerializer.Serialize(v);
var a = MemoryPackSerializer.Deserialize<CaLoginPacket>(bin);
await client.SendAsync(bin);

while (true)
{
    var p = await client.ReceiveAsync();

    if (p == null) // connection dropped
        break;
                
    Console.WriteLine("received back");
}