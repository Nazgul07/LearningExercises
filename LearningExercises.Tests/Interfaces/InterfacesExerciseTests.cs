using System;
using System.Collections.Generic;
using System.Text;
using LearningExercises.LanguageConcepts;
using NUnit.Framework;

namespace LearningExercises.Tests.LanguageConcepts
{
	[TestFixture]
	public class InterfacesExerciseTests
	{
		private InterfacesExercise _exercise = new InterfacesExercise();

		/// <summary>
		/// Expects a valid implentation of IAddTwoNumbers
		/// </summary>
		[TestCase]
		public void ReturnsValidImplementationOfIAddTwoNumbersInterface()
		{
			IAddTwoNumbers impl = _exercise.GetIAddTwoNumbersImplementation() as IAddTwoNumbers;
			Assert.AreEqual(3, impl.AddTwoNumbers(1, 2));
			Assert.AreEqual(9, impl.AddTwoNumbers(4, 5));
			Assert.AreEqual(10, impl.AddTwoNumbers(7, 3));
		}

		/// <summary>
		/// Expects a valid implentation of IAddTwoNumbers and IMultiplyTwoNumbers
		/// </summary>
		[TestCase]
		public void ReturnsValidImplementationOfInterfacesIAddTwoNumbersAndIMultiplyTwoNumbers()
		{
			IAddTwoNumbers impl = _exercise.GetIAddTwoNumbersAndIMultiplyTwoNumbersImplementation() as IAddTwoNumbers;
			Assert.AreEqual(3, impl.AddTwoNumbers(1, 2));
			Assert.AreEqual(9, impl.AddTwoNumbers(4, 5));
			Assert.AreEqual(10, impl.AddTwoNumbers(7, 3));

			IMultiplyTwoNumbers multiply = impl as IMultiplyTwoNumbers;
			Assert.AreEqual(8, multiply.MultiplyTwoNumbers(2, 4));
			Assert.AreEqual(20, multiply.MultiplyTwoNumbers(4, 5));
			Assert.AreEqual(21, multiply.MultiplyTwoNumbers(7, 3));
		}
	}
}
