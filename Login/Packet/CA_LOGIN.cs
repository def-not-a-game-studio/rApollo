using Domain;
using SuperSocket;
using SuperSocket.Command;

namespace Login;

[Command("CA_LOGIN", PacketHeader.CA_LOGIN)]
public class CA_LOGIN : IAsyncCommand<ServerPacket> {

    public ValueTask ExecuteAsync(IAppSession session, ServerPacket package) {
        throw new NotImplementedException();
    }
}