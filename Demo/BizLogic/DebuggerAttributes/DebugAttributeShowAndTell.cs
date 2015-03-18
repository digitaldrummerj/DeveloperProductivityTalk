using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;

namespace BizLogic.DebuggerAttributes
{
	[DebuggerDisplay("There are {Fruits.Count} delicious fruits!")]
	public class DebugAttributeShowAndTell
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<string> _fruits = new List<string>();

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public List<string> Fruits
		{
			get { return _fruits; }
			set { _fruits = value; }
		}

		public void DisplayFruits()
		{
			Console.WriteLine("******");
			Console.WriteLine("DisplayFruits");
			Console.WriteLine("******");
			foreach (string fruit in Fruits)
			{
				Console.WriteLine(fruit);
			}

			HelloWorld();
		}

		[DebuggerHidden]
		public void DisplayFruitsHidden()
		{
			Console.WriteLine("******");
			Console.WriteLine("DisplayFruitsHidden");
			Console.WriteLine("******");

			foreach (string fruit in Fruits)
			{
				Console.WriteLine(fruit);
			}

			HelloWorld();
		}

		[DebuggerStepThrough]
		public void DisplayFruitsStepThrough()
		{
			Console.WriteLine("******");
			Console.WriteLine("DisplayFruitsStepThrough");
			Console.WriteLine("******");

			foreach (string fruit in Fruits)
			{
				Console.WriteLine(fruit);
			}

			HelloWorld();
		}

		public void HelloWorld()
		{
			Console.WriteLine("Hello World!");
		}
	}
}