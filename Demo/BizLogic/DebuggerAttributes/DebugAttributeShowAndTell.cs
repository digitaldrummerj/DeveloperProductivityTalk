using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;

namespace BizLogic.DebuggerAttributes
{
	// Changes how the DebugAttributeShowAndTell looks in the Autos Window
	[DebuggerDisplay("There are {Fruits.Count} delicious fruits!")]
	public class DebugAttributeShowAndTell
	{
		// Won't Show in Debug Windows
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<string> _fruits = new List<string>();

		// Will show contents of List in Debug Windows instead of having to expand Fruits
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

		// the code you are stepping over, does not appear at all in the call stack.  As far as the Call Stack is concerned, it is as if the hidden code does not exist (it is hidden!)
		// CANNOT be set on a class.  
		// CAN Set on method
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

		// The code you are stepping over, appears in the call stack as 'external code' 
		// CAN be set on a class and method
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