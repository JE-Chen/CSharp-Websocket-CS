using System;
using WebSocketSharp.Server;

namespace WebSocket_JE
{
    public class WebSocketServerJe
    {
        public WebSocketServerJe(string url1)
        {
            var webSocketServer = new WebSocketServer(url1);
            webSocketServer.AddWebSocketService<WebSocket>("/websocket");
            webSocketServer.Start();
            while (true)
            {
                var command = Console.ReadLine();
                if (command != null && command.Equals("exit"))
                    break;
            }
        }
    }
}