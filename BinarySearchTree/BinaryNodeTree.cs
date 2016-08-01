using System;
using System.Runtime.InteropServices;

namespace BinarySearchTree
{
	public class BinaryNodeTree<T> where T : IComparable
	{
		BinaryNode<T> root;

		public BinaryNodeTree()
		{
			root = null;
		}

		public BinaryNode<T> Root
		{
			get
			{
				return root;
			}
			set
			{
				root = value;
			}
		}

		public virtual void Clear()
		{
			root = null;
		}

		public void Insert(T value)
		{
			var binaryNode = new BinaryNode<T>(value);
			Insert(binaryNode);
		}

		public void Insert(BinaryNode<T> node)
		{
			if (Root == null)
			{
				Root = node;
				return;
			}

			Insert(node, Root);
		}

		void Insert(BinaryNode<T> nodeToInsert, BinaryNode<T> currentNode)
		{
			var compareToInt = nodeToInsert.Value.CompareTo(currentNode.Value);

			switch (compareToInt)
			{
				case (0):
				case (-1):
					if (currentNode.Left == null)
					{
						currentNode.Left = nodeToInsert;
						return;
					}

					Insert(nodeToInsert, currentNode.Left);
					return;

				case (1):
					if (currentNode.Right == null)
					{
						currentNode.Right = nodeToInsert;
						return;
					}

					Insert(nodeToInsert, currentNode.Right);
					return;

				default:
					return;
			}
		}

		public BinaryNode<T> GetNode(T value)
		{
			return GetNode(value, Root);
		}

		BinaryNode<T> GetNode(T value, BinaryNode<T> node)
		{
			if (node == null)
				return null;

			var compareToInt = value.CompareTo(node.Value);

			switch (compareToInt)
			{
				case (0):
					return node;
				case (1):
					return GetNode(value, node.Right);
				case (-1):
					return GetNode(value, node.Left);
				default:
					return null;
			}
		}

		public BinaryNode<T> GetParentNode(BinaryNode<T> node)
		{
			var parentNode = Root;
			if (Root == null || node == null)
				return null;

			var intComparison = node.Value.CompareTo(Root.Value);


			switch (intComparison)
			{
				case (0):
				case (-1):
					return GetParentNode(node, Root.Left, Root);
				case (1):
					return GetParentNode(node, Root.Right, Root);
				default:
					return null;
			}
		}

		BinaryNode<T> GetParentNode(BinaryNode<T> nodeToFind, BinaryNode<T> currentNode, BinaryNode<T> parentNode)
		{
			if (currentNode == null)
				return null;
			else if (currentNode.Equals(nodeToFind))
				return parentNode;

			var intComparison = nodeToFind.Value.CompareTo(currentNode.Value);
			switch (intComparison)
			{
				case (0):
				case (-1):
					return GetParentNode(nodeToFind, currentNode.Left, currentNode);
				case (1):
					return GetParentNode(nodeToFind, currentNode.Right, currentNode);
				default:
					return null;
			}
		}

		public BinaryNode<T> Remove(T value)
		{
			var nodeToRemove = GetNode(value);
			var parentNode = GetParentNode(nodeToRemove);

			Remove(nodeToRemove, parentNode);

			return nodeToRemove;
		}

		void Remove(BinaryNode<T> currentNode, BinaryNode<T> parentNode)
		{
			if (currentNode == null)
				return;

			if (currentNode.Right != null)
			{
				var rightChildValue = currentNode.Right.Value;
				Remove(currentNode.Right, currentNode);
				currentNode.Value = rightChildValue;
			}

			else if (currentNode.Left != null)
			{
				var leftChildValue = currentNode.Left.Value;
				Remove(currentNode.Left, currentNode);
				currentNode.Value = leftChildValue;
			}
			else
			{
				if (currentNode.Equals(Root))
				{
					Root = null;
					return;
				}
				var compareInt = currentNode.Value.CompareTo(parentNode.Value);
				switch (compareInt)
				{
					case (0):
					case (-1):
						parentNode.Left = null;
						return;
					case (1):
						parentNode.Right = null;
						return;
					default:
						return;
				}
			}
		}

		public override string ToString()
		{
			return ToString(Root);
		}

		string ToString(BinaryNode<T> node)
		{
			if (node == null)
				return " ";

			return $"{ToString(node.Left)}{node.Value.ToString()}{ToString(node.Right)}";
		}
	}
}