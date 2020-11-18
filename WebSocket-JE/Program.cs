using System;
using WebSocketClient_JE;
using WesocketServer_JE;

namespace WebSocket_JE
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSocketClientJE webSocketClientJe = new WebSocketClientJE("ws://192.168.1.36:5050/websocket");
            //WebSocketServerJE webSocketServerJe = new WebSocketServerJE("ws://192.168.1.36:5050");
        }
    }
}