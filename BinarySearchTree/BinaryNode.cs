using System;
namespace BinarySearchTree
{
	public class BinaryNode<T> where T : IComparable
	{
		T data;
		BinaryNode<T> left = null;
		BinaryNode<T> right = null;

		public BinaryNode() { }
		public BinaryNode(T data) : this(data, null, null) { }
		public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
		{
			this.data = data;
			this.left = left;
			this.right = right;
		}

		public T Value
		{
			get
			{
				return data;
			}
			set
			{
				data = value;
			}
		}

		public BinaryNode<T> Right
		{
			get
			{
				return right;
			}
			set
			{
				right = value;
			}
		}

		public BinaryNode<T> Left
		{
			get
			{
				return left;
			}
			set
			{
				left = value;
			}
		}

		public void Insert(BinaryNode<T> node)
		{
			if (Value == null)
			{
				Value = node.data;
				Right = node.Right;
				Left = node.Left;

				return;
			}

			if (node.data.CompareTo(Value) <= 0)
			{
				Left.Insert(node);
				return;
			}

			Right.Insert(node);
		}

		public override string ToString()
		{
			return string.Format("[BinaryNode: Value={0}, Right={1}, Left={2}]", Value, Right, Left);
		}
	}
}

