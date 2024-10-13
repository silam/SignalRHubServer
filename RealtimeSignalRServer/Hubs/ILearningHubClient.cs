using Microsoft.AspNetCore.SignalR;

namespace RealtimeSignalRServer.Hubs
{
    public interface ILearningHubClient 
    {
       Task ReceiveMessage(string message);
    }
}
