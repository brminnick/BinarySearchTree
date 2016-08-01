using System;
using System.Diagnostics;

namespace BinarySearchTree
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var tree = new BinaryNodeTree<int>();

			const int totalNumbers = 20;

			int randomNumber;
			var intArray = new int[20];

			var rnd = new Random();
			for (int i = 0; i < totalNumbers; i++)
			{
				randomNumber = i + 1;
				intArray[i] = randomNumber;

				Debug.WriteLine(randomNumber);

				tree.Insert(randomNumber);
			}
			Debug.WriteLine("Tree ToString():");
			Debug.WriteLine(tree.ToString());

			for (int i = totalNumbers -1 ; i > 0; i--)
			{
				if (i > totalNumbers || i < 0)
					break;

				Debug.WriteLine("");
				Debug.WriteLine($"Remove {intArray[i]}");

				tree.Remove(intArray[i]);

				Debug.WriteLine("Tree ToString():");
				Debug.WriteLine(tree.ToString());
			}
		}
	}
}
