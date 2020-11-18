using System;
using WebSocketSharp.Server;
using WebSocket_JE;

namespace WesocketServer_JE
{
    public class WebSocketServerJE
    {
        public WebSocketServerJE(string url1)
        {
            var webSocketServer = new WebSocketServer(url1);
            webSocketServer.AddWebSocketService<WebSocket>("/websocket");
            webSocketServer.Start();
            while (true)
            {
                var command = Console.ReadLine();
                if (command.Equals("exit"))
                    break;
            }
        }
    }
}