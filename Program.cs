// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SealedClass_Console.Services;

Console.WriteLine("Program start");

// Benchmark speed only
//var summary = BenchmarkRunner.Run<PerformanceBenchmark>();

// Benchmark speed and memory
var summary = BenchmarkRunner.Run<SortBenchmark>();

Console.WriteLine("Program end");