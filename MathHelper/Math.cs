using System.Runtime.InteropServices;
using static System.Math;

namespace MathHelper
{
    internal static class Math
    {
        [DllImport("CLibrary.dll", EntryPoint = "Sqrt")]
        internal static extern double SqrtInvoke(double number);

        internal static double SqrtClr(double number)
        {
            return Sqrt(number);
        }
    }
}
