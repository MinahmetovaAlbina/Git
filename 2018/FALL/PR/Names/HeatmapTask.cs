using System;
using System.Collections.Generic;
using System.IO;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerYearHeatmap(NameData[] names)
        {
            //choose a range
            var maxYear = 1995;
            var minYear = 1945;
            var years = new string[maxYear - minYear + 1];
            for (var y = 0; y < years.Length; y++)
                years[y] = (y + minYear).ToString();

            //create new array of names
            string[] group = File.ReadAllLines(@"group.txt");
            Array.Sort(group);

            //map an index to each name
            var dictionary = new Dictionary<string, int>();
            for (var i = 0; i<group.Length;i++)
                dictionary[group[i]] = i;

            //calculate and fill an array for the amount of born ones
            var birthsCounts = new double[years.Length, group.Length];
            foreach (var e in names)
            {
                var nameYear = e.BirthDate.Year;
                if (dictionary.ContainsKey(e.Name) && minYear <= nameYear && nameYear <= maxYear)
                    birthsCounts[nameYear - minYear, dictionary[e.Name]]++;
            }
            return new HeatmapData(string.Format("Тепловая карта c {0} по {1} гг.", minYear, maxYear), birthsCounts, years, group);
        }
    }
}