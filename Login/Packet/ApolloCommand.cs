using System.Buffers;
using SuperSocket.ProtoBase;
namespace Login; 

public class ApolloCommand : IKeyedPackageInfo<short> {
    public short Key { get; set; }
    
    public ReadOnlySequence<byte> Body { get; set; }
}