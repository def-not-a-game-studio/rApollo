using System.Buffers;
using SuperSocket.ProtoBase;

namespace Login;

public class ApolloPipelineFilter : FixedHeaderPipelineFilter<ApolloCommand> {

    public ApolloPipelineFilter() : base(2) { }
    
    protected override int GetBodyLengthFromHeader(ref ReadOnlySequence<byte> buffer) {
        return 15;
    }
}