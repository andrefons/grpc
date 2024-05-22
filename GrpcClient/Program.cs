using Grpc.Net.Client;
using GrpcService;

var channel = GrpcChannel.ForAddress("https://localhost");

var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(new HelloRequest { Name = "André Fonseca" });

Console.WriteLine(response.Message);

Console.ReadLine();