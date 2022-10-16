// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using SealedClass_Console.Services;

Console.WriteLine("Program start");

var summary = BenchmarkRunner.Run<PerformanceBenchmark>();

Console.WriteLine("Program end");