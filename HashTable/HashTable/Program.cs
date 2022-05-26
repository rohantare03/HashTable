// See https://aka.ms/new-console-template for more information
namespace HashTable 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //uc1 : find frequency of word in sentence
            Console.WriteLine("Welcome to Hashtable");
            LinkedHashMap<string, int> linkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = " paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = linkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else
                    value += 1;
                linkedHashMap.Add(word, value);
            }
            int FrequencyParanoids = linkedHashMap.Get("paranoids");
            int FrequencyAre = linkedHashMap.Get("are");
            int FrequencyNot = linkedHashMap.Get("not");
            int FrequencyParanoid = linkedHashMap.Get("paranoid");
            int FrequencyBecause = linkedHashMap.Get("because");
            int FrequencyThey = linkedHashMap.Get("they");
            int FrequencyBut = linkedHashMap.Get("but");
            int FrequencyKeep = linkedHashMap.Get("keep");
            int FrequencyPutting = linkedHashMap.Get("putting");
            int FrequencyThemselves = linkedHashMap.Get("themselves");
            int FrequencyDeliberately = linkedHashMap.Get("deliberately");
            int FrequencyInto = linkedHashMap.Get("into");
            int FrequencyAvoidable = linkedHashMap.Get("avoidable");
            int FrequencySituations = linkedHashMap.Get("situations");
            Console.WriteLine("The Frequency of word Paranoids is :" + FrequencyParanoids);
            Console.WriteLine("The Frequency of word are is :" + FrequencyAre);         
            Console.WriteLine("The Frequency of word not is :" + FrequencyNot);
            Console.WriteLine("The Frequency of word paranoid is :" + FrequencyParanoid);
            Console.WriteLine("The Frequency of word because is :" + FrequencyBecause);
            Console.WriteLine("The Frequency of word they is :" + FrequencyThey);
            Console.WriteLine("The Frequency of word but is :" + FrequencyBut);
            Console.WriteLine("The Frequency of word keep is :" + FrequencyKeep);
            Console.WriteLine("The Frequency of word putting is :" + FrequencyPutting);
            Console.WriteLine("The Frequency of word themselves is :" + FrequencyThemselves);
            Console.WriteLine("The Frequency of word deliberately is :" + FrequencyDeliberately);
            Console.WriteLine("The Frequency of word into is :" + FrequencyInto);
            Console.WriteLine("The Frequency of word avoidable is :" + FrequencyAvoidable);
            Console.WriteLine("The Frequency of word situations is :" + FrequencySituations);
        }
    }
}

