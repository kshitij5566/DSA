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
			CircularLinkedList<int> list = new CircularLinkedList<int>();
			
			list.PushFirst(10);
			list.PushFirst(20);
			list.PushFirst(30);

			Node<int> temp = list.head;
			do
			{
				Console.Write(temp.data + "-->");
				temp = temp.next;
			}
			while (temp != list.head);

			Console.WriteLine("\n"+list.length);
			Console.Write("");

			Console.ReadKey();
		}
	}
}
