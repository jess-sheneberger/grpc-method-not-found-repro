

using System;
using Grpc.Core;
using Service;

namespace GreeterClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Service.Import.ImportClient(channel);

            var reply = client.Import(new CallOptions());
            Console.WriteLine("Greeting: " + reply.ToString());

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}