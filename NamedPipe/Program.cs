using System;

namespace NamedPipe
{
    class Program
    {
        private const string PipeName = "mytestpipe";
        static void Main(string[] args)
        {
            Console.WriteLine("Running in SERVER mode");
            Console.WriteLine("Press 'q' to exit");
            Server ServerInstance = new Server(PipeName);
            ServerInstance.StartServer();
        }
    }
}
