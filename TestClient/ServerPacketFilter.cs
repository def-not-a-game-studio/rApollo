using System.Buffers;
using SuperSocket.ProtoBase;

namespace Login; 

public class ServerPacketFilter : FixedHeaderPipelineFilter<ServerPacket> {
    public ServerPacketFilter() : base(2) { }
    
    protected override int GetBodyLengthFromHeader(ref ReadOnlySequence<byte> buffer) {
        var reader = new SequenceReader<byte>(buffer);
        //packets can have varying sizes
        return 4;
    }
}