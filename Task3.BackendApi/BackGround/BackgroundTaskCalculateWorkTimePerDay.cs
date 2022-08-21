/*using Data.EF;

public class BackgroundTaskCalculateWorkTimePerDay : BackgroundService
{
    private readonly IServiceProvider _services;
    private readonly IHostApplicationLifetime _lifetime;
    private readonly TaskCompletionSource _source = new(); // 👈 New field
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly Task2DbContext _context;

    public BackgroundTaskCalculateWorkTimePerDay(IServiceProvider services, IHostApplicationLifetime lifetime, IHttpClientFactory httpClientFactory, Task2DbContext context)
    {
        _services = services;
        _lifetime = lifetime;
        _httpClientFactory = httpClientFactory;

        _context = context;

        // 👇 Set the result in the TaskCompletionSource
        _lifetime.ApplicationStarted.Register(() => _source.SetResult());
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await _source.Task.ConfigureAwait(false); // Wait for the task to complete!

        while (!stoppingToken.IsCancellationRequested)
        {
            var everythingInTheDatabase = _context.UserDailyTimesheetModels.ToList();

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7244/");
            foreach (var item in everythingInTheDatabase)
            {
                if (item.TotalActualWorkingTimeInSeconds != null)
                    continue;
                else
                {
                    var response = await client.GetAsync($"/api/Users/CalculateWorkTimePerDay?userId=" +
                       $"{item.UserId}&day={item.Day}&month={item.Month}&year={item.Year}");
                    *//* while (response.StatusCode.ToString() != "200")
                     {
                         response = await client.GetAsync($"/api/Users/CalculateWorkTimePerDay?userId=" +
                      $"{item.UserId}&day={item.Day}&month={item.Month}&year={item.Year}");
                     }*//*

                    var body = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}*/