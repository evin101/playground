using BenchmarkDotNet.Attributes;

namespace TypedConvert
{
    public class ConverterBenchmark
    {

        const int COUNT = 100;

        [Benchmark]
        public void Use_System_Convert()
        {
            for (var i=0;i < COUNT; i++)
            {
                _ = System.Convert.ToByte(i);
            }
        }

        [Benchmark]
        public void Use_System_Convert_ChnageType()
        {
            for (var i = 0; i < COUNT; i++)
            {
                _ = (byte)System.Convert.ChangeType(i, typeof(byte));
            }
        }

        [Benchmark]
        public void Use_TypedConvert()
        {
            for (var i = 0; i < COUNT; i++)
            {
                _ = TypedConvert.Convert.ChangeType<int, byte>(i);
            }
        }

    }
}