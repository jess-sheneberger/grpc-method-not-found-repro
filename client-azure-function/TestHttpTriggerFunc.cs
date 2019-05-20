using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

using Grpc.Core;
using Service;

namespace grpc_method_not_found_repro
{
    public static class TestHttpTriggerFunc
    {
        [FunctionName("TestHttpTriggerFunc")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            // //server
            // Server server = new Server
            // {
            //     Services = { Service.Import.BindService(new ImportImpl()) },
            //     Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) }
            // };
            // server.Start();
            // Console.WriteLine("Server started");

            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Service.Import.ImportClient(channel);

            var opt = new CallOptions(Metadata.Empty);//.WithHeaders(Metadata.Empty);


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
            // server.ShutdownAsync().Wait();

            return new EmptyResult();
        }
    }
}
