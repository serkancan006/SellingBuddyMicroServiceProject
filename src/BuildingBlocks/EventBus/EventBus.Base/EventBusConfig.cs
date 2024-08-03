using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base
{
    public class EventBusConfig
    {
        public int ConnectionRetryCount { get; set; } = 5; // en fazla 5 kere dene bağlanmayı

        public string DefaultTopicName { get; set; } = "SellingBuddyEventBus"; // Exchange ve topic dıiardan verilmez ise default value

        public string EventBusConnectionString { get; set; } = String.Empty;  

        public string SubscriberClientAppName { get; set; } = String.Empty;  // hangi servis queue yaratacak notificationapp, orderapp => OrderService.OrderCreated

        public string EventNamePrefix { get; set; } = String.Empty;  // OrderCreatedIntegrationEvent yerine OrderCreated yapamsı için

        public string EventNameSuffix { get; set; } = "IntegrationEvent";

        public EventBusType EventBusType { get; set; } = EventBusType.RabbitMQ;

        public object Connection { get; set; }


        public bool DeleteEventPrefix => !String.IsNullOrEmpty(EventNamePrefix);
        public bool DeleteEventSuffix => !String.IsNullOrEmpty(EventNameSuffix);
    }

    public enum EventBusType
    {
        RabbitMQ = 0,
        AzureServiceBus = 1
    }
}
