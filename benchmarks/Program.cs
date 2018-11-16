using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using credit.strat;

namespace benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GO");
            BenchmarkRunner.Run<MyBenchmark>();
        }
    }

    [KeepBenchmarkFiles]
    [PlainExporter]
    public class MyBenchmark
    {
        [Benchmark]
        [Arguments(5500, 10, 4)]
        public void Bench(double amount, double fee, double minimum)
        {
            var modelGenerator = new ModelGenerator();

            var model = modelGenerator.GetModels(amount, new ModelSettings { Fee = fee, MinPayment = minimum });
        }
    }
}