using ProtoBuf.Grpc;
using System.ServiceModel;

namespace Nardax.BasicGrpc.ServiceContracts;

[ServiceContract]
public interface IGreeterService
{
    [OperationContract]
    Task<HelloReply> SayHello(HelloRequest request, CallContext context = default);
}