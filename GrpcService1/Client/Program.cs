using Grpc.Net.Client;
using GrpcService1;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new GrpcService1.Greeter.GreeterClient(channel);

            var res = client.SayHello(new HelloRequest() { Name = "Fred" });
            Console.WriteLine(res.Message);
        }
    }
}
