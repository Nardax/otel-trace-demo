using System.Runtime.Serialization;

namespace Nardax.BasicGrpc.ServiceContracts;

[DataContract]
public class HelloReply
{
    [DataMember(Order = 1)]
    public string Message { get; set; }
}