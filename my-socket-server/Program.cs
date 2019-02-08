using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;

namespace mysocketserver
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var appServer = new TelnetServer();

            //if (!appServer.Setup(2012)) //Setup with listening port
            //{
            //    Console.WriteLine("Failed to setup!");
            //    Console.ReadKey();
            //    return;
            //}

            //Console.WriteLine();

            ////Try to start the appServer
            //if (!appServer.Start())
            //{
            //    Console.WriteLine("Failed to start!");
            //    Console.ReadKey();
            //    return;
            //}

            IBootstrap bootstrap = BootstrapFactory.CreateBootstrap();
            bool res = bootstrap.Initialize();

            if (!res)
            {
                Console.WriteLine("Failed to initialize!");
                Console.ReadKey();
                return;
            }

            var result = bootstrap.Start();

            Console.WriteLine("The server started successfully");
        }
    }
}
