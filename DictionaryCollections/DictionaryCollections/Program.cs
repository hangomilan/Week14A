using System;
using System.Collections;


namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable["0"] = "Zero";
            hashtable["1"] = "One";
            hashtable["2"] = "Two";
            hashtable["3"] = "Three";
            hashtable["4"] = "Four";
            hashtable["5"] = "Five";
            hashtable["6"] = "Six";
            hashtable["7"] = "Seven";
            hashtable["8"] = "Eight";
            hashtable["9"] = "Nine";

            string number = "648-257-139";
            foreach (char ch in number)
            {
                string digit = ch.ToString();
                if (hashtable.ContainsKey(digit)) {
                    Console.Write(hashtable[digit]);
                }
                else {
                    Console.Write(ch);
                }

            }
            Console.WriteLine();
        }
    }
}
