using Microsoft.Extensions.Configuration;

namespace clpr;

public class Startup
{
    public Startup()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        Settings = config.GetSection("Settings").Get<Settings>();
    }
    public Settings Settings { get; private set; }
}