using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BizLogic.DebuggerAttributes;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Console App Started");

			var t = new DebugAttributeShowAndTell();
			t.Fruits.Add("Apple");
			t.Fruits.Add("Mango");
			t.Fruits.Add("Banana");

			t.DisplayFruits();

			t.DisplayFruitsHidden();

			t.DisplayFruitsStepThrough();

			Console.WriteLine("Press Enter to Exit....");
			Console.ReadLine();
		}


	}
}
