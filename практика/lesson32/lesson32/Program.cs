using System.Diagnostics;
namespace lesson32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //myClass.DebugWrite();
            //myClass.ReleaseWrite();
            //myClass.OldWrite();
            GetDeveloperInfo(myClass.GetType());

            void GetDeveloperInfo(Type type)
            {
                DeveloperAttribute? developerAttribute = (DeveloperAttribute?)Attribute.GetCustomAttribute(type, typeof(DeveloperAttribute));

                if (developerAttribute is null)
                {
                    Console.WriteLine($"Developer attribute is not applied for{type.FullName}");
                    return;
                }
                Console.WriteLine($"{developerAttribute.FirstName} -> {developerAttribute.Position} -> {developerAttribute.Department}");

            }
        }
    }

    [Developer(FirstName = "John", Position = "Tech Lead", Department = "Security")]
    public sealed class MyClass
    {
        [Conditional("DEBUG")]
        public void DebugWrite()
        {
            Console.WriteLine("Debug mode");
        }

        [Conditional("RELEASE")]
        public void ReleaseWrite()
        {
            Console.WriteLine("Debug/Release mode");
        }

        [Obsolete("This method is obsolete, and will be removed in future versions.")]
        public void OldWrite()
        {
            Console.WriteLine("DO NOT USE THIS METHOD");
        }
    }
    [Serializable]
    [Developer(FirstName = "John", Position = "Tech Lead", Department = "Security")]
    public sealed class Person<TException>:Attribute where TException: Exception
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }

    // Отсюда пишем свой атрибут
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public sealed class DeveloperAttribute : Attribute
    {
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }

}
