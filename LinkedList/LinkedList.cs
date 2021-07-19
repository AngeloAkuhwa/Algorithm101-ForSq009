using System;

namespace CustomLinkedList
{
    public class LinkedList
    {
        internal class Node
        {
            internal int value;
            internal Node Next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private static Node Head;
        private Node Tail;
        private Node PreviousNode;
        private static int size;

        public void AddLast(int number)
        {
            Node newNode = new Node(number);

            if(isEmpty())
            {
                Head = Tail = newNode;
                size++;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
                size++;
            }
        }

       
        public void AddFirst(int number)
        {
            Node newNode = new Node(number);
            if (isEmpty())
            {
                Head = Tail = newNode;
                size++;
                
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                size++;
            }
        }

        public int IndexOf(int item)
        {
            Node current = Head;

            int index = 0;
            while (current != null)
            {
                if (current.value == item)
                {
                    return index;
                }

                index++;
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public static int[] ToArray()
        {
            int[] array = new int[size];
            int index = 0;

            Node current = Head;
            while(current != null)
            {
                array[index] = current.value;

                index++;

                current = current.Next;
            }

            return array;
        }

        public void RemoveLast()
        {
            Node current = Head;

            Node previous = GetPreviousNode();

            Tail = previous;

            previous.Next = null;

            size--;
            

        }

        public void Reverse()
        {
            Node prev = null, current = Head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;

        }
        

        private Node GetPreviousNode()
        {
            Node current = Head;
            while(current != null)
            {
                if(current.Next.Next == null)
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public void PrintOnConsole()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.Next;
            }
        }

        private bool isEmpty()
        {
            return Head == null;
        }

        public bool DetectLoop()
        {
            Node slow = Head, fast = Head; //starting from head of the list

            while ((slow != null) && (fast != null) && (fast.Next != null)) //checking if all elements exist 
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                /* If slow and fast meet at some point then there
                    is a loop */
                if (slow == fast)
                {
                    // Return 1 to indicate that loop is found */
                    return true;
                }
            }
            // Return false to indecate that ther is no loop*/
            return false;
        }

        public void InsertLoop()
        {
            Node temp = Head;
            // traversing to get to last element of the list
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = Head; // pointing last element to head of the list
        }
        
    }
}
