using System;
using System.Diagnostics;
using System.Text;

namespace BinarySearchTree
{
    class MainClass
    {

        static Random random = new Random((int)DateTime.Now.Ticks);

        public static void Main(string[] args)
        {
            var numberOfValuesToTest = 100;

            //intTest(numberOfValuesToTest);

            stringTest(numberOfValuesToTest);           
        }

        private static void stringTest(int totalValues)
        {
            var tree = new BinaryNodeTree<string>();
            
            var stringArray = new string[totalValues];

            var rnd = new Random();

            for (int i = 0; i < totalValues; i++)
            {
                stringArray[i] = RandomString(rnd.Next(1,15));

                Debug.WriteLine(stringArray[i]);

                tree.Insert(stringArray[i]);
            }

            Debug.WriteLine("Tree ToString():");
            Debug.WriteLine(tree.ToString());

            for (int i = 0; i < totalValues; i++)
            {
                if (i > totalValues || i < 0)
                    break;

                var indexToRemove = totalValues - i - 1;
                Debug.WriteLine("");
                Debug.WriteLine($"Remove {stringArray[indexToRemove]}");

                tree.Remove(stringArray[indexToRemove]);

                Debug.WriteLine("Tree ToString():");
                Debug.WriteLine(tree.ToString());
            }
        }

        private static void intTest(int totalValues)
        {
            var tree = new BinaryNodeTree<int>();

            int randomNumber;
            var intArray = new int[totalValues];

            var rnd = new Random();
            for (int i = 0; i < totalValues; i++)
            {
                randomNumber = rnd.Next(1, 100);

                intArray[i] = randomNumber;

                Debug.WriteLine(intArray[i]);

                tree.Insert(intArray[i]);
            }
            Debug.WriteLine("Tree ToString():");
            Debug.WriteLine(tree.ToString());

            for (int i = 0; i < totalValues; i++)
            {
                if (i > totalValues || i < 0)
                    break;

                var indexToRemove = totalValues - i - 1;
                Debug.WriteLine("");
                Debug.WriteLine($"Remove {intArray[indexToRemove]}");

                tree.Remove(intArray[indexToRemove]);

                Debug.WriteLine("Tree ToString():");
                Debug.WriteLine(tree.ToString());
            }
        }

        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
