using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;
using static System.Math;

namespace MathHelper
{
    public class Math
    {
        private const double Number = 0.123556;

        [DllImport("CLibrary.dll", EntryPoint = "Sqrt")]
        private static extern double SqrtInvoke(double number);

        [Benchmark]
        public void SqrtC()
        {
            var _ = SqrtInvoke(Number);
        }

        [Benchmark]
        public void SqrtClr()
        {
            var _ = Sqrt(Number);
        }
    }
}
