using System;

namespace WebSocket_JE
{
    public class WebSocketClientJe
    {
        public WebSocketClientJe(string url)
        {
            using (var webSocketClient = new WebSocketSharp.WebSocket(url))
            {
                webSocketClient.OnMessage += (sender, e) =>
                    Console.WriteLine(e.Data);
                webSocketClient.Connect();
                webSocketClient.Send("C# Connect");
                while (true)
                {
                    string command = Console.ReadLine();
                    if(command != null && command.Equals("exit"))
                        break;
                    webSocketClient.Send(command);
                }
            }
        }
    }
}