using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace BenchmarkDotNetApps;

// Test benchmark on different platforms
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net60)]

// You can define exporters
// [MarkdownExporter, HtmlExporter]

// You can define extras to be analyzed (Threads, Memory, etc)
// This is restricted to some .Net versions though
// [ThreadingDiagnoser]
[MemoryDiagnoser]

// You can define the order results will appear
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class CalcOperations
{
    [Params(1, 200)]
    public int A;

    [Params(1, 500)]
    public int B;

    [Benchmark]
    public int GetSum() => A + B;

    //  This method was defined as the Baseline for the comparison
    [Benchmark(Baseline = true)]
    public int GetTimes() => A * B;
}