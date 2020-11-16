using System;
using WebSocketSharp.Server;
using WebSocket_JE;

namespace WesocketServer_JE
{
    public class WebSocketServerJE
    {
        public WebSocketServerJE(String url1,String url2)
        {
            var webSocketServer = new WebSocketServer(url1);
            webSocketServer.AddWebSocketService<WebSocket>(url2);
            webSocketServer.Start ();
            Console.ReadKey (true);
            webSocketServer.Stop ();

        }
    }
}