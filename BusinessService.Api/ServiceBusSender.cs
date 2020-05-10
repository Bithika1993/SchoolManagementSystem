using Microsoft.Azure.ServiceBus;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Api
{
   
    public class ServiceBusSender
    {
        private readonly QueueClient _queueClient;
       
        private const string QUEUE_NAME ="student";
        public ServiceBusSender()
        {
            
            _queueClient = new QueueClient("Endpoint=sb://servicebuscoredemo.servicebus.windows.net/;SharedAccessKeyName=write;SharedAccessKey=0W4VVz6bzP+SfoUN64cu+dSqUf312PmF5dfigjKjb6U=", QUEUE_NAME);
  
        }
        
        public async Task SendMessage()
        {
            string data = "MyString";
            Message message = new Message(Encoding.UTF8.GetBytes(data));
            await _queueClient.SendAsync(message);
        }
    }
}
