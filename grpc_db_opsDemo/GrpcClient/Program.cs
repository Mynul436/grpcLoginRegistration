
using Grpc.Net.Client;
using GrpcClient;
using GrpcServer;

var channel = GrpcChannel.ForAddress("https://localhost:7024/");
var client = new GrpcClient.Greeter.GreeterClient(channel);
Console.ReadLine();
