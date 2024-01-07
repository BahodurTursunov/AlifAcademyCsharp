namespace lesson18_access_modifier__interceptors_
{

    public class Bar
    {
        public int BarField;
        public int BarProp { get; set;}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new();
            bar.BarField = 1;
            bar.BarProp = 2;

        }
    }
}
