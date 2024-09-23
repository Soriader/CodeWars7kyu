using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class QuarksTask
	{
		private string _color;
		private string _flavor;
		private readonly double _baryonNumber = 1d / 3d; 

		public string Color
		{
			get { return _color; }
			set
			{
				if (value == "red" || value == "blue" || value == "green")
				{
					_color = value;
				}
				else
				{
					throw new ArgumentException("Color can only be red, blue, or green.");
				}
			}
		}

		public string Flavor
		{
			get { return _flavor; }
			set
			{
				if (value == "up" || value == "down" || value == "strange" || value == "charm" || value == "top" || value == "bottom")
				{
					_flavor = value;
				}
				else
				{
					throw new ArgumentException("Choose correct flavor.");
				}
			}
		}

		public double BaryonNumber
		{
			get { return _baryonNumber; } 
		}

		public QuarksTask(string color, string flavor)
		{
			Color = color;
			Flavor = flavor;
		}

		public void Interact(QuarksTask anotherQuark)
		{
			string tempColor = this.Color;  
			this.Color = anotherQuark.Color; 
			anotherQuark.Color = tempColor;  
		}
	}
}
//https://www.codewars.com/kata/5882b052bdeafec15e0000e6/train/csharp