gRPC in 3 minutes (C#)
========================

BACKGROUND
-------------
This is a different version of the helloworld example, using the dotnet SDK
tools to compile [helloworld.proto][] in a common library, build the server
and the client, and run them.

Example projects in this directory depend on the [Grpc](https://www.nuget.org/packages/Grpc/)
and [Google.Protobuf](https://www.nuget.org/packages/Google.Protobuf/) NuGet packages
which have been already added to the project for you.

PREREQUISITES
-------------

- The [.NET Core SDK](https://www.microsoft.com/net/core).

BUILD
-------

From the `examples/csharp/helloworld-from-cli` directory:

- `dotnet restore Greeter.sln`

- `dotnet build Greeter.sln`

Try it!
-------

- Run the server

  ```
  > cd GreeterServer
  > dotnet run
  ```

- Run the client

  ```
  > cd GreeterClient
  > dotnet run
  ```

Tutorial
--------

You can find a more detailed tutorial about Grpc in [gRPC Basics: C#][]

[helloworld.proto]:../../protos/helloworld.proto
[gRPC Basics: C#]:https://grpc.io/docs/tutorials/basic/csharp.html
