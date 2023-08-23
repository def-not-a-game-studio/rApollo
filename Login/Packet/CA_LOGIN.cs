using Domain;
using MemoryPack;
using SuperSocket;
using SuperSocket.Command;

namespace Login;

[Command("CA_LOGIN", PacketHeader.CA_LOGIN)]
public class CA_LOGIN : IAsyncCommand<ApolloCommand> {
    
    public ValueTask ExecuteAsync(IAppSession session, ApolloCommand package) {
        throw new NotImplementedException();
    }
}