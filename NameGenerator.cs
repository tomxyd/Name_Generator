using System;
using System.Collections.Generic;



namespace NameGeneratorDemo
{

    public class NameGenerator
    {
        private List<string> prefixes = new List<string> { "Ael", "Aer", "Af", "Ah", "Al", "Am", "Ama", "An", "Ang", "Ansr", "Ar", "Arn", "Aza", "Bael", "Bas" };
        private List<string> suffixes = new List<string> { "ae", "ael", "aer", "aias", "ah", "aith", "al", "ali", "am", "an", "ar", "ari", "aro", "as", "avel" };


        public string GenerateName()
        {
            var random = new Random();
            int index = random.Next(prefixes.Count);
            string prefix = prefixes[index];
            string suffix = suffixes[index];

            return $"{prefix}{suffix}";
            //return a random item in a list and store it 
        }

        public string GenerateFullName()
        {
            return $"{GenerateName()} {GenerateName()}";
        }

        public string GenerateFullNameWithCredentials(string certfications)
        {
            return $"{GenerateFullName()}, certifications";
        }
    }
}

