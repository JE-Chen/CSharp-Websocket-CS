using System;
using WebSocketSharp;

namespace WebSocketClient_JE
{
    public class WebSocketClientJE
    {
        public WebSocketClientJE(String url)
        {
            using (var webSocketClient = new WebSocket(url))
            {
                webSocketClient.OnMessage += (sender, e) =>
                    Console.WriteLine(e.Data);
                webSocketClient.Connect();
                webSocketClient.Send("EEE");
                Console.ReadKey(true);
            }
        }
    }
}