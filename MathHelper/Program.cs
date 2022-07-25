using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Perfolizer.Horology;

namespace MathHelper
{
    [DisassemblyDiagnoser(maxDepth: 0)]
    [MemoryDiagnoser(displayGenColumns: false)]
    public class Program
    {
        public static void Main(string[] args) =>
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, DefaultConfig.Instance
            .WithSummaryStyle(new SummaryStyle(System.Globalization.CultureInfo.InvariantCulture, printUnitsInHeader: false, SizeUnit.B, TimeUnit.Nanosecond))
            );
    }
}
