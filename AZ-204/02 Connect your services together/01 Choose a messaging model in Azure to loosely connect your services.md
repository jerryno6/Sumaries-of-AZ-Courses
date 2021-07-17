# Messaging model comparation

Fields | Storage Queue | Service Bus | EventGrid | EventHub 
:-----|:-------------:|:-----------:|:---------:|:--------:
Maximum Storage Size | >80Gb | <80Gb | <80Gb | <80Gb 
Expect Subscriber(s) to handle msg | yes | yes | - | - 
Message size | 0-64Kb | 0-256-1M | 0-256-1M | 256-2M 
Support Transaction | - | Yes | ? | ? 
Polling the queue | Yes | No | No | No
Audit, track progress | Yes | ? | ? | ? 
Support Many subscribers | - | Yes | Yes | Yes
Role base Access | - | yes | yes | yes 
Payment || pay for what you use | per event | (20) Consumer groups<br /> (1000) Brokered connections
Multiple events at a time |- | batches messages | several events | Many
Authenticate publisher | - | - | - | Yes
Protocol | REST | HTTPS/AMQP | ? | HTTPS/AMQP
Support Topics | - | depends | Yes | Yes
Save to Blob or DataLake | - | - | - | yes
Filtering  | - | - | Yes (prefix, suffix, eventype) | -
Retention |?| brokered message MAX(int64) <br /> messaging entities 14days -> MAX(int64)| undelivered events -> azStorage | max 7 days

# Different technologies:
- Azure Storage queues: REST-based interface. >80Gb, msgsize: 64kb, audit trail, track progress
- Azure Service Bus: for enterprise applications, utilize multiple communication protocols, have different data contracts, higher security requirements, and can include both cloud and on-premises services.<80Gb, msgsize:256kg-1Mb 
- Azure Event Grid: To notify something to targets
- Azure Event Hubs: is optimized for extremely high throughput, a large number of publishers, security, and resiliency.

# Choose whether to use messages or events
- Message: `raw data`, reference to that data. The sender expect the destination to process this data
- Event: ralated to `publishers` & `subscribers`. Event lighter weight than message. THe publihers has no expectation about the action from the subscribers.
- How to choose messages or events -> Does the sending component expect the communication to be processed in a particular way by the destination component?

# Choose a message-based delivery with queues
- Azure Service Bus topics: are queues which can have multiple subscribers.

### Use Queue storage if you:
- Need an audit trail of all messages that pass through the queue.
- Expect the queue to exceed 80 GB in size.
- Want to track progress for processing a message inside of the queue.

### Use Service Bus queues if you:
- Need an At-Most-Once delivery guarantee.
- Need a FIFO guarantee.
- Need to group messages into transactions.
- Want to receive messages without polling the queue.
- Need to provide a role-based access model to the queues.
- Need to handle messages larger than 64 KB but less than 256 KB.
- Queue size will not grow larger than 80 GB.
- Want to publish and consume batches of messages.

# Choose Azure Event Grid
### concepts in Azure Event Grid 
![concepts in Azure Event Grid](https://docs.microsoft.com/en-us/learn/modules/choose-a-messaging-model-in-azure-to-connect-your-services/media/4-event-grid.png)

### What is an event ?
- Each event is self-contained, can be up to 64 KB ~ 32768 characters ~ 4096words -> Event Grid sends an event to indicate something has happened or changed. However, the actual object that was changed is not part of the event data. Instead, a URL or identifier is often passed to reference the changed object. 
- Different between publisher & event source ? publisher: WHO send this event while eventsource: WHERE the event takes place.
- Event topics: an endpoint; categorize events into groups
- Event Subscriptions define which events on a topic an event handler wants to receive. A subscription can also filter events by their type or subject, so you can ensure an event handler only receives relevant events.

### Use Event Grid when you need these features:
- **Simplicity**: It is straightforward to connect sources to subscribers in Event Grid.
- **Advanced filtering**: Subscriptions have close control over the events they receive from a topic.
- **Fan-out**: You can subscribe to an unlimited number of endpoints to the same events and topics.
- **Reliability**: Event Grid retries event delivery for up to 24 hours for each subscription.
- **Pay-per-event**: Pay only for the number of events that you transmit.

### Event Grid isn't a great solution because it's designed for one-event-at-a-time delivery
- That's the reason why we need EventHub

# Choose Azure Event Hubs
- a single publication (individual or batch) can't exceed 1 MB.
- Use HTTPS or Advanced Message Queuing Protocol (AMQP) 1.0.
- The default of Standard pricing: (20 Consumer groups, 1000 Brokered connections) 

### Authentication:
- All publishers are authenticated and issued a token.

### Choose Event Hubs if:
- You need to support authenticating a large number of publishers.
- You need to save a stream of events to Data Lake or Blob storage.
- You need aggregation or analytics on your event stream.
- You need reliable messaging or resiliency.

