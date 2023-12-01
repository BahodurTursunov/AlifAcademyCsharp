using System.Security.Cryptography.X509Certificates;

namespace lesson3
{
    internal class Bar
    {
        public static void Foo()
        {
            string hello = "hello";
            string str = "text";
            char[] chars = new[] { 't', 'e', 'x', 't' };
            string strFormChars = new(chars);
            string str3 = str + strFormChars;
            Console.WriteLine(str3);

        }

    }
}
