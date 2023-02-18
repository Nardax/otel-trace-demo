using Grpc.Net.Client;
using Nardax.BasicGrpc.ServiceContracts;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Client;

namespace Nardax.BasicGrpc.Client;

public class BasicGrpcClient : IBasicGrpcClient
{
    private GrpcChannel _channel;
    private IGreeterService _client;

    public BasicGrpcClient()
    {
        _channel = GrpcChannel.ForAddress("https://localhost:7078");
        _client = _channel.CreateGrpcService<IGreeterService>();
    }

    public async Task<HelloReply> SayHello(HelloRequest request, CallContext context = default)
    {
        var response = await _client.SayHello(request, context);
        return response;
    }
}