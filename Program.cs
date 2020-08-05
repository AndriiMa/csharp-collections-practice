using System;
using System.Collections.Generic;

namespace csharp_collections_practice
{
    class Program
    
        static void Main(string[] args)
        {

            String text = "Hello my name is Andrew. The name of my cat is Asya";

            String[] words = text.Replace(".", "").ToLower().Split(" ");

            ItemCounter<String> wordCounter = new ItemCounter<String>();

            Dictionary<String, int> wordTable =  wordCounter.CountItems(words);

            foreach( KeyValuePair<String, int> kvp in wordTable){
                Console.WriteLine("Word: {0} \tCount: {1}", kvp.Key, kvp.Value);
            }

        }
    }
}
