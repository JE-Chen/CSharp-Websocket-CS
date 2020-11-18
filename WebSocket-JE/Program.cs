using System;

namespace WebSocket_JE
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var webSocketClientJe = new WebSocketClientJe("ws://192.168.1.36:5050/websocket");
            //WebSocketServerJE webSocketServerJe = new WebSocketServerJE("ws://192.168.1.36:5050");
        }
    }
}