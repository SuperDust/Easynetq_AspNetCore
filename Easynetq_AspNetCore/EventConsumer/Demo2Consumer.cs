using EasyNetQ.AutoSubscribe;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Easynetq_AspNetCore
{
    public class Demo2Consumer : IConsumeAsync<Demo2Message>
    {
        private ILogger _logger;

        public Demo2Consumer(ILogger<DemoConsumer> logger)
        {
            _logger = logger;
        }

        public Task ConsumeAsync(Demo2Message message, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation(message.Title);
            return Task.CompletedTask;
        }
    }
}
