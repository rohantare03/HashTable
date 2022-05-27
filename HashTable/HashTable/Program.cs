// See https://aka.ms/new-console-template for more information
namespace HashTable 
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
            int FrequencyParanoid = linkedHashMap.Get("paranoid");
            Console.WriteLine("The Frequency of word paranoid is :" + FrequencyParanoid);
           
            linkedHashMap.Remove("avoidable");
            int Remove = linkedHashMap.Get("avoidable");
            Console.WriteLine("The frequency of word avoidable : " + Remove);
        }
    }
}

