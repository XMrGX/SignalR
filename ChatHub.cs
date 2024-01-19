using Microsoft.AspNetCore.SignalR;

namespace SignalR.Api;

public class ChatHub : Hub
{
    public async Task OnConnectedAsync(string mensgem)
    {
        await Clients.All.SendAsync("ReceiveMessage", $"{Context.ConnectionId} has joined");
    }
}
