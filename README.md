To reproduce the behavior, you'll need the 'func' commandline tools for Microsoft Azure. 

https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#v2

I created this repro on a Mac. (TODO: test on Windows)

1. Clone this repo
2. In one terminal, start the server in grpc-method-not-found-repro/server: `dotnet run`
3. In another terminal, start the client in grpc-method-not-found-repro/client-azure-function: `func start`
4. Read the output of the last command, there should be a URL where the function is listening, something like `	TestHttpTriggerFunc: [GET,POST] http://localhost:7071/api/TestHttpTriggerFunc`
5. Use curl to trigger the azure function on the URL from the previous step `curl http://localhost:7071/api/TestHttpTriggerFunc`

The HTTP request triggers the Azure function, which fires up a GRPC client and tells it to make a request to the server, server receives the request and sends a response, the Azure function gets the response and completes successfully.

Now, checkout the branch 'broken': `git checkout origin/broken`

The only difference between this branch and master is the version of Grpc.Core is changed from 1.18.0 to 1.20.1.

1. Kill the Azure function host with `ctrl-c` in the client terminal
2. Re-start the Azure function with `func start`
3. Use curl to trigger the function again. `curl http://localhost:7071/api/TestHttpTriggerFunc` Don't forget to use the URL from the output of the previous command.

Expected behavior: Same as before. Instead, the client dies before it can make the request with the runtime exception:
`
[5/20/19 10:22:26 PM] Executed 'TestHttpTriggerFunc' (Failed, Id=de8a73f2-46e2-4ad6-b890-bb955a78a7f0)
[5/20/19 10:22:26 PM] System.Private.CoreLib: Exception while executing function: TestHttpTriggerFunc. client-azure-function: Method not found: 'Void Grpc.Core.CallOptions..ctor(Grpc.Core.Metadata, System.Nullable`1<System.DateTime>, System.Threading.CancellationToken, Grpc.Core.WriteOptions, Grpc.Core.ContextPropagationToken, Grpc.Core.CallCredentials)'.
`
