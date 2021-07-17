# Choose a messaging platform
### Decide between messages and events
- Service Bus topics: temporary storage for messages
- Service Bus queues: temporary storage for messages with multiple subscription
- Service Bus relays: is an object that performs synchronous, two-way communication between applications

### Key advantages of Service Bus queues
- Supports larger messages sizes of 256 KB (standard tier) or 1MB (premium tier) per message versus 64 KB
- Supports both at-most-once and at-least-once delivery - choose between a very small chance that a message is lost or a very small chance it is handled twice
- Guarantees first-in-first-out (FIFO) order - messages are handled in the same order they are added (although FIFO is the normal operation of a queue, it is not guaranteed for every message)
- Can group multiple messages into a transaction - if one message in the transaction fails to be delivered, all messages in the transaction will not be delivered
- Supports role-based security
- Does not require destination components to continuously poll the queue

### Azure service bus topic filters support 3 filter types:
- Boolean
- sql filter, 
- correlation filters: conditions which match properties

### Advantages of storage queues:
- Supports unlimited queue size (versus 80-GB limit for Service Bus queues)
- Maintains a log of all messages

### How to choose a communications technology
1. Is the communication an event? If so, consider using Event Grid or Event Hubs.
2. Should a single message be delivered to more than one destination? If so, use a Service Bus topic. Otherwise, use a queue.

# Exercise - Implement a Service Bus topic and queue
- Create a Service Bus namespace
- Create a Queue
- Create a Topic
    - Create Subscription for America
    - Create subscription for EU

# Exercise - Write code that uses Service Bus queues
- Microsoft.Azure.ServiceBus NuGet package
- We need to provide endpoint, key, queuename to send & receive message from queue

# Exercise - Write code that uses Service Bus topics
