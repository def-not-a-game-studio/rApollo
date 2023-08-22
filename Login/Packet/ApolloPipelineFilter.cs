using SuperSocket.ProtoBase;

namespace Login;

public class ApolloPipelineFilter : FixedSizePipelineFilter<ServerPacket> {

    public ApolloPipelineFilter() : base(2) { }
}