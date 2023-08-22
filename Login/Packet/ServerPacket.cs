using SuperSocket.ProtoBase;
namespace Login; 

public abstract class ServerPacket : IKeyedPackageInfo<short> {
    public short Key { get; }
}