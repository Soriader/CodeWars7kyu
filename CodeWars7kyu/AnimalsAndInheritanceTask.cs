using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWars7kyu
{
	public class AnimalsAndInheritanceTask
	{
		public int Age;
		public int Legs;
		public string Name;
		public string Species;
		public string Status;

		public AnimalsAndInheritanceTask(string name, int age, int legs, string species, string status)
		{
			this.Name = name;
			this.Age = age;
			this.Legs = legs;
			this.Species = species;
			this.Status = status;
		}

		public virtual string Introduce()
		{
			return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
		}
		
	}

	public class Shark : AnimalsAndInheritanceTask
	{
		public Shark(string name, int age, string status) : base(name, age, 0, "shark", status)
		{
		}
	}

	public class Cat : AnimalsAndInheritanceTask
	{
		public Cat(string name, int age, string status) : base(name, age, 4, "cat", status)
		{
		}

		public override string Introduce()
		{
			return base.Introduce() + "  Meow meow!";
		}
	}

	public class Dog : AnimalsAndInheritanceTask
	{
		public string Master { get; private set; }

		public Dog(string name, int age, string status, string master)
			: base(name, age, 4, "dog", status)
		{
			this.Master = master;
		}

		public string GreetMaster()
		{
			return $"Hello {this.Master}";
		}
	}
}
//https://www.codewars.com/kata/56f935002e6c0d55fa000d92/train/csharp