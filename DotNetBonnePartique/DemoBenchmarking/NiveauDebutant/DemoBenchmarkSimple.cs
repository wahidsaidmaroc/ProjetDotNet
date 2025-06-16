using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Text;


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
        private string prenom = "L’intelligence artificielle (IA) révolutionne notre quotidien. Elle permet aux machines d’imiter certaines capacités humaines comme l’apprentissage, la résolution de problèmes et la prise de décision. Grâce à l’IA, de nombreux secteurs évoluent : santé, éducation, industrie, finance, etc. Des assistants virtuels aux voitures autonomes, l’IA transforme notre façon de vivre et de travailler. Elle offre aussi des opportunités pour automatiser les tâches répétitives et améliorer la productivité. Toutefois, son développement soulève des enjeux éthiques, notamment sur la vie privée, l’emploi et la responsabilité. Bien encadrée, l’IA représente un levier puissant pour construire un avenir plus intelligent. ";
        private string nom = "L’intelligence artificielle (IA) révolutionne notre quotidien. Elle permet aux machines d’imiter certaines capacités humaines comme l’apprentissage, la résolution de problèmes et la prise de décision. Grâce à l’IA, de nombreux secteurs évoluent : santé, éducation, industrie, finance, etc. Des assistants virtuels aux voitures autonomes, l’IA transforme notre façon de vivre et de travailler. Elle offre aussi des opportunités pour automatiser les tâches répétitives et améliorer la productivité. Toutefois, son développement soulève des enjeux éthiques, notamment sur la vie privée, l’emploi et la responsabilité. Bien encadrée, l’IA représente un levier puissant pour construire un avenir plus intelligent.";

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

        [Benchmark]
        public StringBuilder GetText()
        {
            var text = new StringBuilder();
            //Concatenation nom et prenom
            text.Append(prenom);
            text.Append(" ");
            text.Append(nom);
            return text;
        }

    }


}
