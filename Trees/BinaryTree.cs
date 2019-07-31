using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	public class BinaryTree<T>
	{
		public TreeNode<T> root;

		public BinaryTree()
		{
			this.root = null;
		}

		public BinaryTree(TreeNode<T> node)
		{
			this.root = node;
		}

		// Inorder traversal of binary tree
		public void PrintInorderTree(TreeNode<T> node)
		{
			if (node == null)
			{
				return;
			}
			else
			{
				PrintInorderTree(node.left);

				Console.Write(node.data + "-->");

				PrintInorderTree(node.right);
			}
		}

		// Preorder traversal of binary tree
		public void PrintPreorder(TreeNode<T> node)
		{
			if (node == null)
				return;

			/* first print data of node */
			Console.Write(node.data + "-->");

			/* then recur on left sutree */
			PrintPreorder(node.left);

			/* now recur on right subtree */
			PrintPreorder(node.right);
		}

		// Postorder traversal of binary tree
		public void PrintPostorder(TreeNode<T> node)
		{
			if (node == null)
				return;

			// first recur on left subtree
			PrintPostorder(node.left);

			// then recur on right subtree
			PrintPostorder(node.right);

			// now deal with the node
			Console.Write(node.data + "-->");
		}

		// Levelorder traversal of tree
		public void PrintLevelOrder(TreeNode<T> node)
		{
			if (node == null)
			{
				return;
			}
			else
			{
				Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
				queue.Enqueue(node);

				while (queue.Count != 0)
				{
					TreeNode<T> currNode = queue.Peek();
					Console.Write(currNode.data + "-->");
					queue.Dequeue();

					if (currNode.left != null)
					{
						queue.Enqueue(currNode.left);
					}
					if (currNode.right != null)
					{
						queue.Enqueue(currNode.right);
					}
				}
			}
		}
	}
}
