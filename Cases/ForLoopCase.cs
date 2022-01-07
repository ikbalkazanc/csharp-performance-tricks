using BenchmarkDotNet.Attributes;

namespace InterestingCases.Cases;

[MemoryDiagnoser]
public class ForLoopCase
{
    private List<int> list = Enumerable.Range(0,500).ToList();
    [Benchmark]
    public void For()
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i].Equals(0);
        }
    }

    [Benchmark]
    public void ForEach()
    {
        foreach (var item in list)
        {
            item.Equals(0);
        }
    }

    [Benchmark]
    public void LinqForEach()
    {
        list.ForEach(item =>
        
            item.Equals(0)
        );
    }


}