using System.Buffers;
using MemoryPack;
using SuperSocket.ProtoBase;

namespace Login;

public class ApolloPackageDecoder : IPackageDecoder<ApolloCommand> {

    public ApolloCommand Decode(ref ReadOnlySequence<byte> buffer, object context) {
        //this wont work...
        //need to know whats the concrete type from the command
        var packet = new CaLoginPacket();
        MemoryPackSerializer.Deserialize(buffer, ref packet);

        return new ApolloCommand { Key = packet.Header, Body = buffer};
    }
}