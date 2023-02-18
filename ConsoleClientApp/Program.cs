// See https://aka.ms/new-console-template for more information

using Nardax.BasicGrpc.Client;
using Nardax.BasicGrpc.ServiceContracts;

var basicGrpcClient = new BasicGrpcClient();

var helloRequest = new HelloRequest
{
    Name = "Requestor 10001"
};

var response = await basicGrpcClient.SayHello(helloRequest);

Console.WriteLine($"Greeting: {response.Message}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();