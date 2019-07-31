using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryTree<int> tree = new BinaryTree<int>();
			tree.root = new TreeNode<int>(1);
			tree.root.left = new TreeNode<int>(2);
			tree.root.right = new TreeNode<int>(3);
			tree.root.left.left = new TreeNode<int>(4);
			tree.root.left.right = new TreeNode<int>(5);
			tree.PrintLevelOrder(tree.root);

			Console.ReadKey();
		}
	}
}
