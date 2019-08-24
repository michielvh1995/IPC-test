using System;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Process pipeClient = new Process();
            pipeClient.StartInfo.FileName = "pipeClient.exe";

            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            {
                Console.WriteLine("[SERVER] Current mode: {0}.", pipeServer.TransmissionMode);
                // test
            }
        }
    }
}
