using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDataStructure
{
    public class MyDictionary
    {
        public char FindFirstNonRepeatingCharacter(string str)
        {
            Dictionary<char, int> characterSets = new Dictionary<char, int>();

            foreach (char character in str)
            {
                if (characterSets.ContainsKey(character))
                {
                    characterSets[character]++;
                }
                else
                {
                    characterSets.Add(character, 1);
                }

            }

            foreach (var (key, value) in characterSets)
            {
                if (characterSets[key] == 1)
                {
                    return key;
                }
            }

            return default(char);
        }

        public char FindFirstRepeatingCharacter(string str)
        {
            Dictionary<char, int> characterSets = new Dictionary<char, int>();

            foreach (char character in str)
            {
                if (characterSets.ContainsKey(character))
                {
                    characterSets[character]++;
                }
                else
                {
                    characterSets.Add(character, 1);
                }

            }

            foreach (var item in characterSets)
            {
                if (item.Value > 1)
                {
                    return item.Key;
                }
            }

            return default(char);
        }

        public char OptimisedFindingFirstRepeatedCharacter(string str)
        {            
            HashSet<char> listOfChars = new HashSet<char>();

            foreach (char character in str)
            {
                if (listOfChars.Contains(character))
                {
                    return character;
                }
                else
                {
                    listOfChars.Add(character);
                }
            }

            return default(char);
        }
    }
}
