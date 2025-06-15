using BenchmarkDotNet.Attributes;
namespace BoucleForVsForeach;

[MemoryDiagnoser]
public class LoopBenchmark
{
    private List<int> numbers;

    [GlobalSetup]
    public void Setup()
    {
        numbers = Enumerable.Range(0, 10_000).ToList();
    }

    [Benchmark]
    public int SumWithFor()
    {
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
            sum += numbers[i];
        return sum;
    }

    [Benchmark]
    public int SumWithForeach()
    {
        int sum = 0;
        foreach (var n in numbers)
            sum += n;
        return sum;
    }
}
