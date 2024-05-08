namespace ThreadSafeSingletonPattern
{
    public static class Program
    {
        private static void Main()
        {
            // The client code.

            Console.WriteLine(
                              "{0}\n{1}\n\n{2}\n",
                              "If you see the same value, then singleton was reused (yay!)",
                              "If you see different values, then 2 singletons were created (booo!!)",
                              "RESULT:"
                             );

            var process1 = new Thread(() => { TestSingleton("FOO"); });
            var process2 = new Thread(() => { TestSingleton("BAR"); });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        private static void TestSingleton(string value)
        {
            var singleton = Singleton.GetInstance(value);

            Console.WriteLine(singleton.Value);
        }
    }
}