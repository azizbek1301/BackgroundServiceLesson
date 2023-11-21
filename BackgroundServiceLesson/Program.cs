using BackgroundServiceLesson;

var builder = WebApplication.CreateBuilder(args);

// backgroundservice ro'yxatdan o'tkazish

builder.Services.AddHostedService<BackgroundServiceTest>();

builder.Services.Configure<HostOptions>(options =>
{
    options.StartupTimeout = TimeSpan.FromSeconds(30);
    options.ShutdownTimeout = TimeSpan.FromSeconds(30);
    //options.ShutdownTimeout = TimeSpan.FromSeconds(10);
});

var app = builder.Build();
app.Run();
