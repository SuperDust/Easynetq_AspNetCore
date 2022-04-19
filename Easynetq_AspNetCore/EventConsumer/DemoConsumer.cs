using EasyNetQ.AutoSubscribe;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Easynetq_AspNetCore
{
    public class DemoConsumer : IConsumeAsync<DemoMessage>
    {
        private ILogger _logger;

        public DemoConsumer(ILogger<DemoConsumer> logger)
        {
            _logger = logger;
        }

        public Task ConsumeAsync(DemoMessage message, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation(message.Title);
            return Task.CompletedTask;
        }
    }
}
