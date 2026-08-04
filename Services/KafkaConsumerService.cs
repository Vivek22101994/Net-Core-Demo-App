using Confluent.Kafka;

public class KafkaConsumerService : BackgroundService
{
    private readonly IConsumer<string, string> _consumer;
    private readonly ILogger<KafkaConsumerService> _logger;

    public KafkaConsumerService(IConfiguration config, ILogger<KafkaConsumerService> logger)
    {
        _logger = logger;

        var consumerConfig = new ConsumerConfig
        {
            BootstrapServers = config["Kafka:BootstrapServers"],
            GroupId = "my-service-group",
            AutoOffsetReset = AutoOffsetReset.Earliest,
            EnableAutoCommit = false // manual commit for at-least-once reliability
        };

        _consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _consumer.Subscribe("orders-topic");

        // Run the blocking Consume loop on a background thread so it
        // doesn't tie up a thread-pool thread with sync blocking calls
        await Task.Run(() =>
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var result = _consumer.Consume(stoppingToken);
                    ProcessMessage(result.Message.Value);
                    _consumer.Commit(result); // commit only after successful processing
                }
                catch (ConsumeException ex)
                {
                    _logger.LogError(ex, "Consume error: {Reason}", ex.Error.Reason);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
        }, stoppingToken);
    }

    private void ProcessMessage(string value)
    {
        // your business logic
    }

    public override void Dispose()
    {
        _consumer.Close();
        base.Dispose();
    }
}