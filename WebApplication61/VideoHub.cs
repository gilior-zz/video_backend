using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication61
{
    public class VideoHub : Hub
    {
        public void HandleMsg( string message)
        {
            Clients.All.messageFromServer(message);
        }
    }
}