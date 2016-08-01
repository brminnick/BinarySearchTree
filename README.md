# BinarySearchTree
 This repo contains the Binary Search Tree data structure. It allows for fast lookup and addition of items, and can be used to implement either dynamic sets of items, or lookup tables that allow finding an item by its key (e.g., finding the phone number of a person by name).
 
  Binary search tree is a rooted binary tree, whose internal nodes each store a value and each have two distinguished sub-trees, denoted Left and Right. The tree additionally satisfies the binary search tree property, which states that the value in each node must be greater than all values stored in the left sub-tree, and smaller than all values in the right sub-tree. (The leaves (final nodes) of the tree contain no value and have no structure to distinguish them from one another. Leaves are represented by null.)

|| Average | Worst Case|
|-----|---------|-----------|
|Space|	Θ(n)|O(n)|
|Search|Θ(log n)|O(n)|
|Insert|Θ(log n)|O(n)|
|Delete|Θ(log n)|O(n^2)|
