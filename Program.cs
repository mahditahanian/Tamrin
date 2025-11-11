// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");







Parallel.For(0, 4, i =>
{
    int threadId = Thread.CurrentThread.ManagedThreadId;

    var inst1 = FactorManager.Instance;
    var inst2 = FactorManager.Instance;
    var inst3 = FactorManager.Instance;

    Console.WriteLine($"[Thread {threadId}] HashCodes: {inst1.GetHashCode()}, {inst2.GetHashCode()}, {inst3.GetHashCode()}");
});









