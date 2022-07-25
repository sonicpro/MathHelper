using System.Runtime.InteropServices;

namespace MathHelper
{
    internal static class Math
    {
        [DllImport("CLibrary.dll", EntryPoint = "Sqrtf")]
        internal static extern float Sqrtf(float number);
    }
}
