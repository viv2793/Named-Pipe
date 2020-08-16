# Named-Pipe-IPC
This is repository contains implmentation for Named-Pipe Server as a Console Application in C#.

## Background
Recently, I came across a requirement that we need to communicate between two different executables where one executable was written in C# and second executable was written in Golang. So I decided to use named-pipe as a way to implement IPC. This repo contains named-pipe server implementation as a Console Application. 

## Steps to run - 
- Download and install Visual Studio (Visual Studio 2019 Community Edition has been used to write this)
- Open NamedPipe.sln in Visual Studio
- Build this project by clicking on the build option given at top bar of Visual Studio. 
```
Build -> Build Solution
```
- Open powershell(Windows) and navigate to the path project path named-pipe-ipc/NamedPipe/bin/Debug/netcoreapp3.1 and run below command in powershell - 
```
NamedPipe.exe
```
- The above command will run namedpipe server and can receive message from any client.
- Key 'q' on the keyboard has to be pressed to stop the server.

Note - This is supports only Windows platform only.

