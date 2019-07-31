using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
	public class TreeNode<T>
	{
		public T data;
		public TreeNode<T> left;
		public TreeNode<T> right;

		public TreeNode(T d)
		{
			this.data = d;
			this.left = null;
			this.right = null;
		}
	}
}
