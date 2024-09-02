using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars7kyu
{
	public class LinkedListsPushBuildOneTwoThreeTask
	{
		public int Data;
		public LinkedListsPushBuildOneTwoThreeTask Next;

		public LinkedListsPushBuildOneTwoThreeTask(int data)
		{
			this.Data = data;
			this.Next = null;
		}

		public static LinkedListsPushBuildOneTwoThreeTask Push(LinkedListsPushBuildOneTwoThreeTask head, int data)
		{
			LinkedListsPushBuildOneTwoThreeTask newNode = new LinkedListsPushBuildOneTwoThreeTask(data);
			newNode.Next = head;
			return newNode;
		}

		public static LinkedListsPushBuildOneTwoThreeTask BuildOneTwoThree()
		{
			LinkedListsPushBuildOneTwoThreeTask list = null;
			list = Push(list, 3); 
			list = Push(list, 2); 
			list = Push(list, 1); 
			return list;
		}
	}
}
//https://www.codewars.com/kata/55be95786abade3c71000079/train/csharp