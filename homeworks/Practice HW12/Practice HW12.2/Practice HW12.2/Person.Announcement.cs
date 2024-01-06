namespace Practice_HW12._2
{
    public partial class Person
    {
        partial void LogName(string name);

        public void DisplayName()
        {
            string fullName = "John Doe";
            LogName(fullName);
        }

    }
}
