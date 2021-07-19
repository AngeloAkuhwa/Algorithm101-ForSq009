using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class AlgorithBasics 
    {
        public int FindANumber(int[] arr)
        {
            //1,2,3,4,5
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 5)
                {
                    return arr[i];
                }
            }

           return -1;
            
        }

        public char GetMostRepeatedChar(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return default;//'o/'
            }

            Dictionary<char, int> resultHolder = new Dictionary<char, int>();

            foreach (char letter in word)
            {
                if (resultHolder.ContainsKey(letter))
                {
                    resultHolder[letter]++;
                }
                else
                {
                    resultHolder.Add(letter,1);
                }
                //a 2
                //c 3
            }
            int max = 0;
            char returnType = 'a';
            foreach (var item in resultHolder)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                    returnType = item.Key;
                }

            }

            return returnType;
        }
    }

}
