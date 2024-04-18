namespace Practice_HW43
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var resultTask = WorkAsync();
            int result = await resultTask;
        }

        public static async Task<int> WorkAsync()
        {
            await Task.Delay(3000);
            await Console.Out.WriteLineAsync("Working");
            return 40;
        }
    }
}
