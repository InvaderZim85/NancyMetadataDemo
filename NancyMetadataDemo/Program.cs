using System;
using Nancy.Hosting.Self;

namespace NancyMetadataDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var hostConfig = new HostConfiguration
                {
                    UrlReservations = new UrlReservations { CreateAutomatically = true }
                };

                var url = $"http://localhost:8080/";
                var uri = new Uri(url);

                var host = new NancyHost(hostConfig, uri);
                host.Start();

                Console.WriteLine($"Service started. Service is listening on {url}. Press enter to exit.");
                Console.ReadLine();

                host.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
                Console.ReadLine();
            }
        }
    }
}
