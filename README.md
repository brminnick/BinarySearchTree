# BinarySearchTree
 This repo contains the Binary Search Tree data structure. It allows for fast lookup and addition of items, and can be used to implement either dynamic sets of items, or lookup tables that allow finding an item by its key (e.g., finding the phone number of a person by name).
 
  Binary search tree is a rooted binary tree, whose internal nodes each store a value and each have two distinguished sub-trees, denoted Left and Right. The tree additionally satisfies the binary search tree property, which states that the value in each node must be greater than all values stored in the left sub-tree, and smaller than all values in the right sub-tree. (The leaves (final nodes) of the tree contain no value and have no structure to distinguish them from one another. Leaves are represented by null.)

|| Average | Worst Case|
|-----|---------|-----------|
|Space|	?(n)|O(n)|
|Search|?(log n)|O(n)|
|Insert|?(log n)|O(n)|
|Delete|?(log n)|O(n^2)|

### Example

```
 static Random random = new Random((int)DateTime.Now.Ticks);
 private void stringTest(int totalValues)
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
 ```