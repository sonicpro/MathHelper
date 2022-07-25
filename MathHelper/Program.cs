using System;
using static MathHelper.Math;

namespace MathHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SqrtInvoke(16.0) == SqrtClr(16.0));
        }
    }
}
