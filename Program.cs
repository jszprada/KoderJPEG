using BenchmarkDotNet.Running;
using KoderJPEG;
var summary = BenchmarkRunner.Run<Benchmarks.BmpToJpegBenchmarks>();

//string[] strings = { "boats24.bmp", "lena24.jpg" };
//int q = 90;
//BmpToJpeg.EncoderQuality();
//BmpToJpeg.Convert(strings,q);




