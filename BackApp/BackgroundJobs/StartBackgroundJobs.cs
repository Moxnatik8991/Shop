using Hangfire;
using Shop.BackApp.BackgroundJobs.Interfaces;
using Shop.BackApp.Services.Interfaces;

namespace Shop.BackApp.BackgroundJobs
{
    public class StartBackgroundJobs : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        public StartBackgroundJobs(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var _productJobs = _serviceProvider.GetService<IProductJobs>();

            RecurringJob.AddOrUpdate(
                "UpdatingProducts", // Уникальное имя задачи
                () => _productJobs.UpdatingProducts(), 
                Cron.Hourly(5));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            // Логика для остановки задач, если необходимо
            return Task.CompletedTask;
        }
    }


}
