using Microsoft.Extensions.Configuration;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;




namespace SampleConApp
{
    public class AppSettings
    {
        public string AppName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
    internal class Ex26ReadingConfig
    {
        public static IConfiguration AppConfig { get; private set; }
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            AppConfig = config;

            var appName = AppConfig["AppSettings:AppName"];
            var title = AppConfig["AppSettings:Title"];

            Console.WriteLine($"~~~~~~~~~~{appName.ToUpper()}~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"~~~~~~~~~~{title.ToUpper()}~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();

            var appSettings = new AppSettings();
            //config.Bind("AppSettings", appSettings);
            config.GetSection("AppSettings").Bind(appSettings);
            Console.WriteLine($"App Name: {appSettings.AppName}");


        }
    }
}
