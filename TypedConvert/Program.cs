using BenchmarkDotNet.Running;
using System;

namespace TypedConvert
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ConverterBenchmark>();
        }
    }
}