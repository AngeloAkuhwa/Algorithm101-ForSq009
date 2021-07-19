using QueueDataStructure;
using StackDataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsReview
{

    class Program
    {
        public static int[] removeEven(int[] Arr, int size)
        {            
            int count = 0;

           for (int i = 0; i < size; i++)
           {
                if (Arr[i] % 2 != 0)
                {
                    Arr[count++] = Arr[i];
                }
               
           }

            int[] newArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = Arr[i];
            }
            Arr = newArray;
            return Arr;
        }

       

        public static int[] mergeArrays(int[] arr1, int[] arr2, int arr1Size, int arr2Size)
        {
            // int[] arr3 = new int[arr1Size + arr2Size];  // creating a new array

            //arr3 = arr1.Concat(arr2).ToArray();

            // Array.Sort(arr3);
            // return arr3; // returning array
            int[] arr3 = new int[arr1Size + arr2Size];  // creating a new array
            for (int i = 0; i < arr1Size; i++)
            {
                arr3[i] = arr1[i];
            }

            int lenght = arr2Size + arr1Size;
            int count = 0;
            for (int i = arr1Size; i < lenght; i++)
            {
                arr3[i] = arr1[count++];
            }

            Array.Sort(arr3);
            return arr3; // returning array
        }

        public static int[] findProduct(int[] arr, int size)
        {
            int[] product = new int[size];
            int result = 1;
            // Write your code here
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        result *= arr[j];
                    }
                }
                product[i] = result;
                result = 1;
            }
            return product;
        }
        static void Main(string[] args)
        {

            PriorityQueue queue = new PriorityQueue();
            var x = queue.ArraySorting(new int[] {2,58,46,89,5,8,4,8,1,1,2,9,7,5,31,5,7,7,4,5 });
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            //bool stackMethod = MyStack.IsBalancedExpression("[1+3*6/7(jhbvdsgh)[]{}]");
            //Console.WriteLine(stackMethod);


            // MyDelegateDemo cc = new MyDelegateDemo();
            //var result = cc.areaCalculator.Invoke(0);
            // cc.messageWiter("bjduhd");
            // Console.WriteLine(result);
            // cc.AnonymousMethod();
            // Console.WriteLine();
            // cc.GenericDelegateWithoutReturnType();
            // Console.WriteLine(cc.CalculatingUsingExpressionTree());



            //List<int> num = new List<int>();
            //List<bool> listOfFlags = new List<bool>();
            //var str = "5-6-7-8-13";
            //foreach (var item in str)
            //{
            //    if (char.IsDigit(item))
            //    {
            //        var ele = int.Parse(item.ToString());

            //        num.Add(ele);

            //    }
            //}

            //for (int i = 0; i < num.Count-1; i++)
            //{
            //    if(Math.Abs(num[i] - num[i + 1]) > 1)
            //    {
            //        listOfFlags.Add(false);
            //    }
            //    else if(Math.Abs(num[i] - num[i + 1]) < 1)
            //    {
            //        listOfFlags.Add(false);
            //    }
            //    else
            //    {
            //        listOfFlags.Add(true);
            //    }

            //}

            //if (listOfFlags.Contains(false))
            //{
            //    Console.WriteLine("not consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("consecutive");
            //}

            // Console.WriteLine("FirstName");
            // var firstName = Console.ReadLine();


            // Console.WriteLine("LastName");
            // var lastName = Console.ReadLine();

            // Console.WriteLine("Email");
            // var email = Console.ReadLine();


            // User userModel = new User();
            // userModel.FirstName = firstName;
            // userModel.LastName = lastName;
            // userModel.Email = email;

            // AuthenticationRepository authentication = new AuthenticationRepository();
            // var returnRegResponse = authentication.RegisterUser(userModel,"angelo");
            // Console.WriteLine(returnRegResponse);

            // UserRepository userData = new UserRepository();
            //User user =  userData.GetUserByEmail("angeloakuhwa@gmail.com");
            // Console.WriteLine(user.Id);
            // Console.WriteLine(user.FirstName);
            // Console.WriteLine(user.LastName);
            // Console.WriteLine(user.Email);
            // Console.WriteLine(user.DateCreated.ToString("dd-MM-yyyy"));

            // Console.WriteLine("User Id");
            // int userId = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Street");
            // var street = Console.ReadLine();

            // Console.WriteLine("Town");
            // var town = Console.ReadLine();

            // Console.WriteLine("State");
            // var state = Console.ReadLine();

            // Console.WriteLine("Country");
            // var Country = Console.ReadLine();

            // Address userAddress = new Address();
            // userAddress.UserId = userId;
            // userAddress.StreetName = street;
            // userAddress.Town = town;
            // userAddress.State = state;
            // userAddress.country = Country;
            // AddressRepository userAddressData = new AddressRepository();
            // userAddressData.AddAdress(userAddress, "angeloakuhwa@gmail.com");

            // var addressToGet = userAddressData.GetUerAddress(1);
            // Console.WriteLine(addressToGet.country);
            // Console.WriteLine(addressToGet.State);


            // var yeah = Program.ReverseString(null);

            // foreach(var item in yeah)
            // {
            //     Console.Write(item.ToString());
            // }

            // int[] array3 = { 1, 2, 3, 4};
            //var result3 = Program.findProduct(array3, 4);
            // foreach (var item in result3)
            // {
            //     Console.WriteLine(item);
            // }

            // int[] array1 = { 1, 2, 4, 5, 10, 6, 3 };
            // int[] array2 = { 1, 2, 4, 5, 10, 6, 3 };

            // var result1 = Program.mergeArrays(array1, array2, 7, 7);

            // foreach (var item in result1)
            // {
            //     Console.WriteLine(item);
            // }

            // int[] array = { 1, 2, 4, 5, 10, 6, 3 };
            //var result = Program.removeEven( array, 7);

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }



            //int[][] matrix = new int[2][];
            //matrix[0] = new int[2] { 1,3};
            //matrix[1] = new int[6] { 3,4,5,5,6,4};
            //// Continue filling in values for the jagged array...
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (int column = 0; column < matrix[row].Length; column++)
            //        Console.Write(matrix[row][column] + " next "); // Each item in the row separated by spaces
            //    Console.WriteLine(); // Rows separated by lines
            //}


            //var random = new Random();
            //random.Next();


            //var curr = 445;

            //int playersNumber = -1;
            //while (playersNumber < 0 || playersNumber > 10)
            //{
            //    // This code will get repeated until the player types in a number between 0 and 10.
            //    Console.Write("Enter a number between 0 and 10: ");
            //    string playerResponse = Console.ReadLine();
            //    playersNumber = Convert.ToInt32(playerResponse);
            //}
            ////int playersNumber;
            ////do
            ////{
            ////    Console.Write("Enter a number between 0 and 10: ");
            ////    string playerResponse = Console.ReadLine();
            ////    playersNumber = Convert.ToInt32(playerResponse);
            ////}
            ////while (playersNumber < 0 || playersNumber > 10);

            ////int numberThatCausesProblems = 54;
            //int j;
            //for ( j = 1; j <= 100; j++)
            //{
            //    Console.WriteLine(j);
            //    if (j == numberThatCausesProblems) break;

            //}

            //while (true)
            //{
            //    Console.Write("What is thy bidding, my master? ");
            //    string input = Console.ReadLine();
            //    if (input == "quit" || input == "exit")
            //        break;
            //}
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int column = 0; column < 10; column++)
            //        Console.Write("*");
            //    Console.WriteLine(); // This makes it wrap around to the beginning of the line.
            //    Console.WriteLine();
            //}

            //for (int row = 0; row < 10; row++)
            //{
            //    for (int column = 0; column < row + 1; column++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}

            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentMinimum = Int32.MaxValue; // We start high, so that any element in the array will be lower.
            ////for (int index = 0; index < array.Length; index++)
            ////{
            ////    if (array[index] < currentMinimum)
            ////        currentMinimum = array[index];
            ////}

            //int counter = 0; ;
            //while (counter < array.Length)
            //{
            //    if (array[counter] < currentMinimum)
            //    {
            //        currentMinimum = array[counter];
            //    }
            //    counter++;
            //}



            //Console.WriteLine("currentminimum" + currentMinimum);

            //int i, j, n;

            //Console.Write("\n\n");
            //Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
            //Console.Write("----------------------------------------------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input number of rows for this pattern :");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    for (j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.Write("\n");
            //}
            //for(i = 1; i<=100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if(i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if( i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }


            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(Student.DisplayStudentInfo(ref curr));

            //Console.WriteLine(curr);
            //var now = curr.ToString("");
            //Console.WriteLine(now);

            //dynamic number = 9;
            //Student.DisplayStudentInfo(number);



        }

       
    }

   
}
