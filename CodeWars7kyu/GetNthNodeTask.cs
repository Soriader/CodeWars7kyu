using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars7kyu
{
	public class GetNthNodeTask
	{
		public int Data;
		public GetNthNodeTask Next;

		public GetNthNodeTask(int data)
		{
			this.Data = data;
			this.Next = null;
		}

		public static GetNthNodeTask GetNth(GetNthNodeTask node, int index)
		{
			if (node == null) throw new ArgumentException("List is empty");
			if (index < 0) throw new ArgumentException("Index cannot be negative");

			GetNthNodeTask current = node;
			int count = 0;

			while (current != null)
			{
				if (count == index)
					return current;

				current = current.Next;
				count++;
			}

			throw new ArgumentException("Index out of bounds");
		}
	}
}
//https://www.codewars.com/kata/55befc42bfe4d13ab1000007/train/csharp