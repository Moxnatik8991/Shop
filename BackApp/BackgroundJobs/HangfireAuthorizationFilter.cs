using Hangfire.Dashboard;

namespace Shop.BackApp.BackgroundJobs;

public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
{
    public bool Authorize(DashboardContext context)
    {
        // Вернуть true для разрешения доступа всем пользователям
        return true;
    }
}
