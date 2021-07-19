using System;

namespace CustomArray
{
    public class CustArray
    {
        private int[] items;
        private int count;
        public CustArray(int length)
        {
            items = new int[length];  
        }


        public void Print()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Insert(int number)
        {
            items[count] = number;
            count++;
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < count-1; i++)
            {
                items[i] = items[i + 1];
               
            }

            int lenght = items.Length - 1;

            int[] newItemsArray = new int[lenght];

            for (int i = 0; i < newItemsArray.Length; i++)
            {
                newItemsArray[i] = items[i];
            }

            items = newItemsArray;
        }
        
        public int IndexOf(int data)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if(items[i] == data)
                {
                    return i;
                }
               
            }

            return -1;
        }

        

        
    }
}
