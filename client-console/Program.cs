using System;
using System.IO;
using System.Threading;

using Grpc.Core;
using Service;

namespace Program
{
    public static class Program
    {
        public static void Main()
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Service.Import.ImportClient(channel);

            var opt = new CallOptions();//.WithHeaders(Metadata.Empty);

            var stream = client.Import(opt);
            var r = new ImportRequest();
            r.Source = new Row();
            r.Source.Data = Google.Protobuf.ByteString.CopyFromUtf8("test1234");
            
            Console.WriteLine("Client sending request");
            stream.RequestStream.WriteAsync(r).Wait();
            stream.ResponseStream.MoveNext(new CancellationToken()).Wait();
            Console.WriteLine("Client got response: "+stream.ResponseStream.Current.ToString());

            ///cleanup
            channel.ShutdownAsync().Wait();
        }
    }
}
