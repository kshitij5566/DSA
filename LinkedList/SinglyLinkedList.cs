using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
	public class Node<T>
	{
		public T data;
		public Node<T> next;

		//public Node()
		//{
			
		//}
		public Node(T d)
		{
			this.data = d;
			this.next = null;
		}
	}

	public class SinglyLinkedList<T>
	{
		// Declaring head node of the list
		public Node<T> head;

		// Length property denoting number of nodes in the list
		public int length;

		// Default constructor to initialize the list with null head node
		//public SinglyLinkedList()
		//{
		//	Node<T> newNode = new Node<T>();
		//	head = newNode;
		//	length = 0;
		//}

		// Parametarized constructor to initialize list with head node
		public SinglyLinkedList( T data)
		{
			Node<T> newNode = new Node<T>(data);
			head = newNode;
			length = length + 1;
		}

		// Method to insert a node at the begining of list
		public void PushFirst(T data)
		{
			Node<T> newNode = new Node<T>(data);

			if (head == null)
			{
				head = newNode;
				length++;
			}
			else
			{
				Node<T> temp = head;
				newNode.next = temp ;
				head = newNode;
				length++;
			}
		}

		// Method to insert a node at the end of the list
		public void PushBack(T data)
		{
			Node<T> newNode = new Node<T>(data);

			if (head == null)
			{
				head = newNode;
				length++;
			}
			else
			{
				Node<T> temp = head;
				while (temp.next != null)
				{
					temp = temp.next;
				}
				temp.next = newNode;
				length++;
			}
		}
	}
}
