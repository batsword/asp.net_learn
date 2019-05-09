
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.SignalR
{
    public class MyChatHub:Hub
    {
        public async Task SendMessage(string userName,string message)
        {
            await Clients.All.SendAsync("SendMessage", userName, message);
        }

        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendOtherMessage(string userName, string message)
        {
            await Clients.All.SendAsync("SendMessage", userName, message);
        }



    }
}
