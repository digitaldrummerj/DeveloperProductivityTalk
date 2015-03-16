using System;
using BizLogic;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class UnitTest2
	{
		private float _firstNumber = 30;
		private float _secondNumber = 10;

		[Test]
		public void AddTest()
		{


			Assert.AreEqual(40, new Calculator().Add(this._firstNumber, this._secondNumber));
		}

		[Test]
		public void SubtractTest()
		{
			Assert.AreEqual(-20, new Calculator().Substract(this._firstNumber, this._secondNumber));
		}
	}
}
