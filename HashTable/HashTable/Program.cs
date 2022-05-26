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
            string sentence = "to be or not to be";
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
            int FrequencyTo = linkedHashMap.Get("to");
            int FrequencyBe = linkedHashMap.Get("be");
            int FrequencyOr = linkedHashMap.Get("or");
            int FrequencyNot = linkedHashMap.Get("not");
            Console.WriteLine("The Frequency of word to is :" + FrequencyTo);
            Console.WriteLine("The Frequency of word be is :" + FrequencyBe);
            Console.WriteLine("The Frequency of word or is :" + FrequencyOr);
            Console.WriteLine("The Frequency of word not is :" + FrequencyNot);
        }
    }
}

