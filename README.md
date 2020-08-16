# Named-Pipe-IPC
This is repository contains implmentation for Named-Pipe Server as a Console Application in C#.

Windows Named-pipe Documentation : https://docs.microsoft.com/en-us/windows/win32/ipc/named-pipes

## Background
Recently, I came across a requirement where I needed to communicate between two different running executables(.exe) where one executable was written in C# and second executable was written in Golang. So I decided to use named-pipe as a way to implement IPC. This repo contains named-pipe server implementation as a Console Application. There is another repo which creates [named-pipe client](https://github.com/viv2793/named-pipe-ipc) for IPC. That client is purely implemented in Golang.

## Steps to run - 
- [Download](https://visualstudio.microsoft.com/vs/community/) and install Visual Studio (Visual Studio 2019 Community Edition has been used to write this)
- Open NamedPipe.sln in Visual Studio
- Build this project by clicking on the build option given at top bar of Visual Studio. 
```
Build -> Build Solution
```
- Open powershell(Windows) and navigate to the path project path named-pipe-ipc/NamedPipe/bin/Debug/netcoreapp3.1 and run below command in powershell - 
```
NamedPipe.exe
```
- The above command will run namedpipe server and the server can now receive messages from any named-pipe client.
- Key 'q' on the keyboard has to be pressed to stop the server.

Note - This is supports Windows platform only.

## Credits - 
- https://github.com/natefinch
