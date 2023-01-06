using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using KoderJPEG;

namespace Benchmarks;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[MinColumn, MaxColumn, MeanColumn, MedianColumn]
[InProcessAttribute]
public class BmpToJpegBenchmarks
{   
    public string[] strings = { "boats24.bmp", "lena24.bmp", "MARBLES.bmp", "sample_5184×3456.bmp", "a.bmp","b.bmp", "c.bmp", "d.bmp", "e.bmp", "f.bmp", "g.bmp" };
    
    [Params(20, 50, 90, 95)]
    public int Quality { get; set; }
    [Benchmark]
    public void Test()
    {
        ConvertAndMeasurePerformance();
    }
    public void ConvertAndMeasurePerformance()
    {
        var stopwatch = Stopwatch.StartNew();

        BmpToJpeg.Convert(strings, Quality);

        stopwatch.Stop();
        Console.WriteLine($"Conversion took {stopwatch.ElapsedMilliseconds} milliseconds");
    }

}

