using Nardax.BasicGrpc.ServiceContracts;
using ProtoBuf.Grpc;

namespace Nardax.BasicGrpc.Service;

public class GreeterService : IGreeterService
{
    public Task<HelloReply> SayHello(HelloRequest request, CallContext context = default)
    {
        return Task.FromResult(
            new HelloReply
            {
                Message = $"Hello {request.Name}"
            });
    }
}