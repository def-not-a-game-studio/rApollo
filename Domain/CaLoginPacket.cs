using MemoryPack;
namespace Login; 

[MemoryPackable]
public partial class CaLoginPacket {
    public short Header;
    public string Login;
}