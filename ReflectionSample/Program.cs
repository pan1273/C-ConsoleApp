using System;

namespace ReflectionSample
{
    class Hoge
    {
        public int publicField;
        private int privateField;

        public int publicProperty { get; set; }
        private int privateProperty { get; set; }

        public void PublicMethod() { return; }
        private void PrivateMethod() { return; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var hoge = new Hoge();
            Type type = hoge.GetType();

            var publicMembers = type.GetMembers();
            Console.WriteLine("Public Members");
            Write(publicMembers);

            var publicFields = type.GetFields();
            Console.WriteLine("Public Fields");
            Write(publicFields);

            var publicProperties = type.GetProperties();
            Console.WriteLine("Public Properties");
            Write(publicProperties);

            var publicMethod = type.GetMethods();
            Console.WriteLine("Public Method");
            Write(publicMethod);
        }

        public static void Write(dynamic list)
        {
            foreach(dynamic info in list)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();
        }
    }
}
