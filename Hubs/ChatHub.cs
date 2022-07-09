using Microsoft.AspNetCore.SignalR;

namespace BlazorChatSignalR.Server.Hubs
{
    public class ChatHub: Hub
    {
        public override async Task OnConnectedAsync()
        {
            await AddMessageToChat("", "user connected");
            await base.OnConnectedAsync();
        }



        public async Task AddMessageToChat(string user, string message)
        {
            await Clients.All.SendAsync("GetThatMessageDude" ,user, message);
        }
    }
}
