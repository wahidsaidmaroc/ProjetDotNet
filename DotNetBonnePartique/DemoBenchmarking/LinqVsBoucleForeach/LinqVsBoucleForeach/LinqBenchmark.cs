

using BenchmarkDotNet.Attributes;

namespace LinqVsBoucleForeach;

[MemoryDiagnoser]
public class LinqBenchmark
{
    private List<int> data;

    [GlobalSetup]
    public void Setup()
    {
        data = Enumerable.Range(0, 10_000).ToList();
    }

    [Benchmark]
    public int WithLinq() => data.Where(x => x % 2 == 0).Sum();

    [Benchmark]
    public int WithLoop()
    {
        int sum = 0;
        foreach (var x in data)
            if (x % 2 == 0)
                sum += x;
        return sum;
    }
}
