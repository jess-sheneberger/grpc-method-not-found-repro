protoc -I ./ ./service.proto --csharp_out=. --plugin=protoc-gen-grpc=$(which grpc_csharp_plugin) --grpc_out=.

cp *.cs client-azure-function
cp *.cs server