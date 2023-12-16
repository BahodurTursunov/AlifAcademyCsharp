namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegate int[] Sort(int[] arr);

            //static void Main(string[] args)
            //{
            //    Sort sort = new Sort(BubbleSort);
            //    int[] unsortedArray = { 1, 4, 4, 2, 4, 7, 8, 4, 2, 22, 11 };
            //    int[] sortedArray = sort(unsortedArray);
            //    int[] BubbleSort(int[] arr) => arr;

            //    foreach (var item in sortedArray)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            // Immutability 
            Point3D point3D = new(10, 0, 20);
            Point3D point3D1 = point3D with { X = 1000, Z = 234 };

            Int128
        }
    }



    public record Point3D(double X, double Y, double Z);

    public record struct Point2D(double X, double Y);
    //public record struct Point3D(double X, double Y, double Z)
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //    public double Z { get; set; }
    //}



    public record Car(string Model, string Brand, string Engine, string Color, short YearOfIssue, short MaxSpeed);

    public record Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public short Age { get; set; }

        public string Gender { get; set; }

        public void Sleep()
        {
            // TODO: Sleep
        }
    }
}
// TODO: как оператор равенста работает в recordax см.sharplab

//struct declare section

public struct Coordinate
{
    public double X { get; set; }

    public double Y { get; set; }

    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }
}


// TODO: ref struct изучить самостоятельно