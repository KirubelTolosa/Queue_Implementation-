using System;

namespace Queue_Implementation
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue test = new Queue();
			test.Enqueue(1);
			test.Enqueue(2);
			test.Enqueue(3);
			test.Enqueue(4);
			test.Enqueue(5);
			test.Enqueue(6);
			test.Print();
			int removed = test.Dequeue();
			test.Print();
			Console.WriteLine("The removed item is : " + removed);
			Console.WriteLine(test.Peek());
			Console.WriteLine(test.IsEmpty());
		}
	}
	public class Queue
	{
		Node headNode;
		Node tailNode;
		public Queue()
		{
			headNode = tailNode = null;
		}
		// Finding the tail O(n) InEfficient
		public Node FindTailNode()
		{
			Node temp = headNode;
			while (temp.next != null)
			{
				temp = temp.next;
			}
			return temp;
		}
		public int Peek()
		{
			if (headNode != null)
				return headNode.data;
			else
				return 0;
		}
		public bool IsEmpty()
		{
			return (headNode == null && tailNode == null);
		}
		public void Enqueue(int data)
		{
			Node newNode = new Node(data);
			if (headNode == null)
			{
				headNode = newNode;
			}
			if (tailNode != null)
			{
				tailNode.next = newNode;
			}
			tailNode = newNode;
			/*
			if (headNode == null)
			{
				headNode = new Node(data);				
			}
			else
			{
				FindTailNode().next = new Node(data);
			}*/
		}
		public int Dequeue()
		{
			int data = headNode.data;
			headNode = headNode.next;
			if (headNode == null)
				tailNode = null;
			return data;
		}
		public void Print()
		{
			if (headNode == null)
			{
				Console.WriteLine("There is no element in here");
			}
			else
			{
				Node temp = headNode;
				while (temp != null)
				{
					Console.Write("|" + temp.data + "|->");
					temp = temp.next;
				}
				Console.WriteLine();
			}
		}
	}
	public class Node
	{
		public int data;
		public Node next;
		public Node(int data)
		{
			this.data = data;
			next = null;
		}
	}
}