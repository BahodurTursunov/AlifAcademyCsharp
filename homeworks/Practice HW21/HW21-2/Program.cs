namespace HW21_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int far = int.Parse(Console.ReadLine());
            Faringate(far);

        }

        static void Faringate(int x)
        {
            _ = x switch
            {
                <= 32 => "Вода находится в состоянии льда",
                >= 32 and < 212 => "Вода в жидком состоянии",
                > 212 => "Вода находится в парообразном состоянии"
            };
        }
    }

}

