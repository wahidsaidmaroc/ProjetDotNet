using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;


namespace NiveauDebutant
{ 
    [MemoryDiagnoser]
    public class DemoBenchmarkSimple
    {
        [Benchmark]
        public int Add() => 2 + 2;
    }




    [MemoryDiagnoser]
    public class StringBenchmark
    {
        private string prenom = "Said";
        private string nom = "Wahid";

        [Benchmark]
        public string ConcatWithPlus()
        {
            return prenom + " " + nom;
        }

        [Benchmark]
        public string Interpolation()
        {
            return $"{prenom} {nom}";
        }
    }


}
