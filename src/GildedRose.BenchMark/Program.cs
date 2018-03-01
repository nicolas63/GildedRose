using BenchmarkDotNet.Running;

namespace GildedRose.BenchMark
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchClass>();
        }
    }
}
