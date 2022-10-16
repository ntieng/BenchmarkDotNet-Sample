using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SealedClass_Console.Entities;

namespace SealedClass_Console.Services;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class PerformanceBenchmark
{
    private readonly Bear _bear = new();
    private readonly Husky _husky = new();

    ///Tesing for Void method
    [Benchmark]
    public void Sealed_VoidMethod() => _husky.DoNothing();
    [Benchmark]
    public void Open_VoidMethod() => _bear.DoNothing(); 
}