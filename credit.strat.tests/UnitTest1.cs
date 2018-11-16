using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using credit.strat;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            BenchmarkRunner.Run<MyBenchmark>();
        }
    }

    [KeepBenchmarkFiles]
    [CsvExporter]
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