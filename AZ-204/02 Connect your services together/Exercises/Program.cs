using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace privatemessagesender
{
    class Program
    {

        const string ServiceBusConnectionString = "Endpoint=sb://vulesvcbus0520.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=PgjshS41z4tirvzTd585Lzv0L2Ar6+aQurJsJdJjRPM=";
        const string QueueName = "salesmessages";
        const string TopicName = "salesperformancemessages";
        const string SubscriptionAmerica = "Americas";
        static IQueueClient queueClient;
        static TopicClient topicClient;
        static SubscriptionClient subscriptionClient;

        static void Main(string[] args)
        {
            Console.WriteLine("Sending a message to the Sales Messages queue...");

            //send message to QUEUE
            SendSalesMessageAsync().GetAwaiter().GetResult();

            //receive message from QUEUE
            ReceiveSalesMessageAsync().GetAwaiter().GetResult();

            //send message to TOPIC
            SendMessageToTopicAsync().GetAwaiter().GetResult();

            //receive message from TOPIC
            ReceiveMessageFromTopic().GetAwaiter().GetResult();

        }

        #region SEND MESSAGE TO QUEUE
        static async Task SendSalesMessageAsync()
        {
            // Create a Queue Client here
            queueClient = new QueueClient(ServiceBusConnectionString, QueueName);
            for (int i = 0; i < new Random().Next(2, 5); i++)
            {
                // Send messages.
                try
                {
                    string messageBody = $"$10,000 order for bicycle parts from retailer Adventure Works.";
                    var message = new Message(Encoding.UTF8.GetBytes(messageBody));
                    Console.WriteLine($"Sending message {i}: {messageBody}");
                    await queueClient.SendAsync(message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
                }
            }

            // Close the connection to the queue here
            await queueClient.CloseAsync();
        }
        #endregion

        #region RECEIVE MESSAGE FROM QUEUE
        static async Task ReceiveSalesMessageAsync()
        {

            queueClient = new QueueClient(ServiceBusConnectionString, QueueName);

            Console.WriteLine("======================================================");
            Console.WriteLine("Please wait while we are reading messaages");
            Console.WriteLine("======================================================");

            RegisterMessageHandler();

            Console.WriteLine("======================================================");
            Console.WriteLine("Press ENTER key to exit after receiving all the messages.");
            Console.WriteLine("======================================================");
            Console.Read();

            await queueClient.CloseAsync();

        }

        static void RegisterMessageHandler()
        {
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };
            queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        }

        static async Task ProcessMessagesAsync(Message message, CancellationToken token)
        {
            Console.WriteLine($"Received message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");
            await queueClient.CompleteAsync(message.SystemProperties.LockToken);
        }

        static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Console.WriteLine($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            Console.WriteLine("Exception context for troubleshooting:");
            Console.WriteLine($"- Endpoint: {context.Endpoint}");
            Console.WriteLine($"- Entity Path: {context.EntityPath}");
            Console.WriteLine($"- Executing Action: {context.Action}");
            return Task.CompletedTask;
        }
        #endregion

        #region SEND MESSAGE TO TOPIC
        static async Task SendMessageToTopicAsync()
        {
            topicClient = new TopicClient(ServiceBusConnectionString, TopicName);

            try
            {
                string message = "Cancel! I can't believe you use canned mushrooms!";
                var encodedMessage = new Message(Encoding.UTF8.GetBytes(message));
                await topicClient.SendAsync(encodedMessage);

                Console.WriteLine($"Sent message: {message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{DateTime.Now} :: Exception: {ex.Message}");
            }
            

            await topicClient.CloseAsync();
        }
        #endregion

        #region RECEIVE MESSAGE FROM TOPIC

        static async Task ReceiveMessageFromTopic()
        {

            Console.WriteLine("======================================================");
            Console.WriteLine("Press ENTER key to exit after receiving all the messages.");
            Console.WriteLine("======================================================");
            subscriptionClient = new SubscriptionClient(ServiceBusConnectionString, TopicName, SubscriptionAmerica);

            TopicRegisterMessageHandler();

            Console.Read();

            await subscriptionClient.CloseAsync();
        }

        static void TopicRegisterMessageHandler()
        {
            var messageHandlerOptions = new MessageHandlerOptions(TopicExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };
            subscriptionClient.RegisterMessageHandler(TopicProcessMessagesAsync, messageHandlerOptions);
        }

        static async Task TopicProcessMessagesAsync(Message message, CancellationToken token)
        {
            Console.WriteLine($"Received sale performance message: SequenceNumber:{message.SystemProperties.SequenceNumber} Body:{Encoding.UTF8.GetString(message.Body)}");
            await subscriptionClient.CompleteAsync(message.SystemProperties.LockToken);
        }

        static Task TopicExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Console.WriteLine($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            Console.WriteLine("Exception context for troubleshooting:");
            Console.WriteLine($"- Endpoint: {context.Endpoint}");
            Console.WriteLine($"- Entity Path: {context.EntityPath}");
            Console.WriteLine($"- Executing Action: {context.Action}");
            return Task.CompletedTask;
        }

        #endregion

    }
}
