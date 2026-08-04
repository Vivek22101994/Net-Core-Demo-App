using Confluent.Kafka;

public class KafkaProducerService : IDisposable
{
    private readonly IProducer<string, string> _producer;

    public KafkaProducerService(IConfiguration config)
    {
        var producerConfig = new ProducerConfig
        {
            BootstrapServers = config["Kafka:BootstrapServers"], // e.g. "localhost:9092"
            Acks = Acks.All,                    // wait for all in-sync replicas
            EnableIdempotence = true,           // exactly-once semantics per partition
            MessageSendMaxRetries = 3,
            LingerMs = 5                        // small batching delay for throughput
        };

        _producer = new ProducerBuilder<string, string>(producerConfig).Build();
    }

    public async Task PublishAsync(string topic, string key, string payload)
    {
        var message = new Message<string, string> { Key = key, Value = payload };

        try
        {
            var result = await _producer.ProduceAsync(topic, message);
            // result.Status == PersistenceStatus.Persisted on success
        }
        catch (ProduceException<string, string> ex)
        {
            // ex.Error.Reason, ex.Error.Code
            throw;
        }
    }

    public void Dispose() => _producer?.Dispose();
}