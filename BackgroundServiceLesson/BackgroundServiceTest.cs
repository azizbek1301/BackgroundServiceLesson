
namespace BackgroundServiceLesson
{
    public class BackgroundServiceTest : IHostedLifecycleService
    {
        private readonly ILogger<BackgroundServiceTest> _logger;

        public BackgroundServiceTest(ILogger<BackgroundServiceTest> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartAsync");
            return Task.CompletedTask;
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartingAsync");
            return Task.CompletedTask;
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StartedAsync");
            return Task.CompletedTask;
        }


        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StopAsync");
            return Task.CompletedTask;
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StoppingAsync");
            return Task.CompletedTask;
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("StoppedAsync");
            return Task.CompletedTask;
        }

    }
}
