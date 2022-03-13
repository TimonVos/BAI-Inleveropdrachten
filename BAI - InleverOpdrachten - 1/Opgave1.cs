namespace BAI___InleverOpdrachten___1
{
    public static class Opgave1
    {
        /// <summary>
        /// Recursively filters out the numbers that only appear once
        /// </summary>
        /// <param name="lijst">The list you wish to filter</param>
        /// <returns>The list without all the number that only appeared once</returns>
        public static List<int> FilterList(List<int> lijst)
        {

            Dictionary<int, int> NumberAmounts = ReturnDictionaryAmounts(new Dictionary<int, int>(), lijst, 0);


            foreach (var i in NumberAmounts)
            {
                Console.WriteLine(i);
            }
            // List<int> FilteredList = ReturnFilteredList(lijst, NumberAmounts, 0);
            List<int> FilteredList = ReturnFilteredList(lijst, NumberAmounts, 0);

            return FilteredList;


        }

        /// <summary>
        /// Creates a Dictionary that has the number as the key and the amount of times it appears as the value
        /// </summary>
        private static Dictionary<int, int> ReturnDictionaryAmounts(Dictionary<int, int> dictionary, List<int> lijst, int index)
        {
            if (index < lijst.Count)
            {
                ReturnDictionaryAmounts(dictionary, lijst, index + 1);
                if (dictionary.ContainsKey(lijst[index]))
                {
                    dictionary[lijst[index]]++;
                }
                else
                {
                    dictionary.Add(lijst[index], 1);
                }
            }
            return dictionary;
        }


        /// <summary>
        /// Filters out the numbers that only appear in the list once
        /// </summary>
        private static List<int> ReturnFilteredList(List<int> lijst, Dictionary<int, int> dictionary, int index)
        {
            if (index < lijst.Count)
            {
                if (dictionary[lijst[index]] <= 1)
                {
                    lijst.Remove(index);
                    lijst = ReturnFilteredList(lijst, dictionary, index + 1);
                    return lijst;
                }
                else
                {
                    lijst = ReturnFilteredList(lijst, dictionary, index + 1);
                    return lijst;
                }
            }
            else
            {
                return lijst;
            }
        }
    }
}
