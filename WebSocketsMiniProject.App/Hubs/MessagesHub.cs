using Microsoft.AspNetCore.SignalR;

namespace WebSocketsMiniProject.App.Hubs;

public class MessagesHub : Hub
{
    /// <summary>
    /// inside this async method, SendAsync("MethodName", handler) used in JS to use events to interaction with other clients
    /// </summary>
    /// <param name="message"></param>
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}