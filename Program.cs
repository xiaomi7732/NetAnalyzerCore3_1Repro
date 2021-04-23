using System;

namespace LearnAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test aa = new Test();
            
        }
    }

    public class Test : IDisposable
    {
        public void Dispose()
        {
            
        }
    }

    public enum TestEnumNoZero
    {
        Unknown = 1
    }
}
