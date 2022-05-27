// See https://aka.ms/new-console-template for more information
namespace HashTable 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);

            string sentence = "paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("paranoid");
            Console.WriteLine(frequency);

            LinkedHashMap.Remove("avoidable");
            int frequency1 = LinkedHashMap.Get("avoidable");

            Console.WriteLine(frequency1);
        }
    }
}

