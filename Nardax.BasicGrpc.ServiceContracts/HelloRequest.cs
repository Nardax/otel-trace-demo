using System.Runtime.Serialization;

namespace Nardax.BasicGrpc.ServiceContracts;

[DataContract]
public class HelloRequest
{
    [DataMember(Order = 1)]
    public string Name { get; set; }
}