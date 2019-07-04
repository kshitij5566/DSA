using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			SinglyLinkedList<int> list = new SinglyLinkedList<int>(50);
			list.PushBack(10);
			list.PushBack(20);
			list.PushBack(30);

			while (list.head != null)
			{
				Console.Write(list.head.data + "-->");
				list.head = list.head.next;
			}
			Console.WriteLine("\n"+list.length);

			Console.ReadKey();
		}
	}
}
