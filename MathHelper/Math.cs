using BenchmarkDotNet.Attributes;
using System.Runtime.InteropServices;
using static System.Math;

namespace MathHelper
{
    internal static class Math
    {
        private const double Number = 0.123556;

        [DllImport("CLibrary.dll", EntryPoint = "Sqrt")]
        private static extern double SqrtInvoke(double number);

        [Benchmark]
        public static void SqrtC()
        {
            var _ = SqrtInvoke(Number);
        }

        [Benchmark]
        internal static void SqrtClr()
        {
            var _ = Sqrt(Number);
        }
    }
}
