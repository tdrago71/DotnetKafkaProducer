// See https://aka.ms/new-console-template for more information
using KafkaProducer;

Console.WriteLine("Hello!, This is my Kafka Producer Application");
ProduceMessage produceMessage = new ProduceMessage();
produceMessage.CreateMessage().Wait();