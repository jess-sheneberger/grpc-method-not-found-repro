

using System;
using System.Threading;
using Grpc.Core;
using Service;

namespace Program
{
    class ImportImpl : Service.Import.ImportBase {
        public override global::System.Threading.Tasks.Task Import(Grpc.Core.IAsyncStreamReader<ImportRequest> requestStream, Grpc.Core.IServerStreamWriter<ImportResponse> responseStream, Grpc.Core.ServerCallContext context) {
            var res = new ImportResponse();
            res.Result = "result123xyz";
            Console.WriteLine("Server got request, sending response");
            return responseStream.WriteAsync(res);
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {            
            //server
            Server server = new Server
            {
                Services = { Service.Import.BindService(new ImportImpl()) },
                Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) }
            };
            server.Start();
            Console.WriteLine("Server started - slam enter to exit");


            Console.ReadLine();
            server.ShutdownAsync().Wait();
        }
    }
}