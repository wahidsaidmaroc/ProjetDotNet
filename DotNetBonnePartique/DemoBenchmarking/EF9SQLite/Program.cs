// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using EF9SQLite;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<EfBenchmarks>();



//Créer un benchmark EF Core 9 dans Visual Studio qui compare :

//.ToList() avec suivi

//.AsNoTracking().ToList() sans suivi
//Tu pourras ensuite interpréter les résultats (Mean, Allocated, Gen0).