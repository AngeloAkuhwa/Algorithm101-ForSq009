using System;
using System.Text;

namespace QueueDataStructure
{
    public class PriorityQueue
    {
        int[] resultHolder;
        private int size;
        public PriorityQueue()
        {
            resultHolder = new int[5];
        }
        public void Add(int item)
        {
            if (size == resultHolder.Length) throw new ArgumentOutOfRangeException();

            int i;
            for (i = size-1; i >= 0; i--)
            {
                if(resultHolder[i] > item)
                {
                    resultHolder[i + 1] = resultHolder[i];
                }
                else
                {
                    break;
                }
            }

            resultHolder[i+1] = item;
            size++;

            
        }

        public void Print()
        {
            foreach (var item in resultHolder)
            {
                Console.WriteLine(item);
            }

            
        }

       

        public int[] ArraySorting(int[] input)
        {
            //method one: bubble sorting approach: though inefficient

            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);

            return input;

        }
    }
}
