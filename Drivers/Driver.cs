using Microsoft.Extensions.Configuration;
using Microsoft.Playwright;

namespace SpecFlowSecond.Drivers
{
    public class Driver : IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;

        
        //bool runInPipelineMode = configuration.GetValue<bool>("RunInPipelineMode");
        public Driver()
        {
            _page = InitializePlaywright();            
        }
        public IPage Page => _page.Result;

        private async Task<IPage> InitializePlaywright()
        {
            string originalPath = Directory.GetCurrentDirectory();
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(originalPath)
                    .AddJsonFile("appsettings.json")
                    .AddUserSecrets<Program>()
                    .Build();

            var playwright = await Playwright.CreateAsync();

            var browserType = configuration["browser"];
            var isHeadless = bool.Parse(configuration["isHeadless"]);

            BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions
            {
                Headless = isHeadless
                // Other options can be added as needed
            };

            switch (browserType.ToLower())
            {
                case "firefox":
                    _browser = await playwright.Firefox.LaunchAsync(launchOptions);
                    break;
                case "chrome":
                    _browser = await playwright.Chromium.LaunchAsync(launchOptions);
                    break;
                case "edge":
                    _browser = await playwright.Webkit.LaunchAsync(launchOptions);
                    break;
                default:
                    // Handle other browser types or provide a default option
                    throw new ArgumentException("Unsupported browser type specified in appsettings.json");
            }

            var page = await _browser.NewPageAsync();
            return page;
        }

        public void Dispose() => _browser?.CloseAsync();
    }
}
