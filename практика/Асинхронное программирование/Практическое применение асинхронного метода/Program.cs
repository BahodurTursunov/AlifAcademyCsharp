namespace Практическое_применение_асинхронного_метода
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("THREAD ID: " + Thread.CurrentThread.ManagedThreadId);

            Task<string> strTask1 = GetWebSiteAsync("http://example.com", "str1");
            Task<string> strTask2 = GetWebSiteAsync("http://example.com", "str2");
            Task<string> strTask3 = GetWebSiteAsync("http://example.com", "str3");
            Task<string> strTask4 = GetWebSiteAsync("http://example.com", "str4");

            Console.ReadLine();
        }

        static async Task<string> GetWebSiteAsync(string url, string request)
        {
            Console.WriteLine("THREAD ID: " + Thread.CurrentThread.ManagedThreadId);

            using HttpClient httpClient = new HttpClient();
            Task<string> contextStringTask = httpClient.GetStringAsync(url);
            await Task.Delay(1000);
            Console.WriteLine(request);
            return await contextStringTask;
        }
    }
}
