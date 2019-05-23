using LearningExercises.List;
using NUnit.Framework;
using System.Collections.Generic;

namespace LearningExercises.Tests.List
{
	[TestFixture]
	public class ListExerciseTests
	{
		private ListExercise _exercise = new ListExercise();
		
		/// <summary>
		/// Expects a list contents to be reversed.
		/// </summary>
		[TestCase]
		public void ReturnsTheListReversed()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5};
			Assert.AreEqual(new List<int> { 5, 4, 3, 2, 1 }, _exercise.ReverseList(list));
		}

		/// <summary>
		/// Expects a list to have the last value removed
		/// </summary>
		[TestCase]
		public void ReturnsTheListWithLastValueRemoved()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			Assert.AreEqual(new List<int> { 1, 2, 3, 4 }, _exercise.RemoveLast(list));
		}

		/// <summary>
		/// Expects a list to have the third value removed
		/// </summary>
		[TestCase]
		public void ReturnsTheListWithThirdValueRemoved()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			Assert.AreEqual(new List<int> { 1, 2, 4, 5 }, _exercise.RemoveThirdItem(list));
		}

		/// <summary>
		/// Expects a list to have the second and fourth value removed
		/// </summary>
		[TestCase]
		public void ReturnsTheListWithSecondAndThirdRemoved()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			Assert.AreEqual(new List<int> { 1, 3, 5 }, _exercise.RemoveSecondAndFourthItem(list));
		}

		/// <summary>
		/// Expects a response of the sum of values from the list
		/// </summary>
		[TestCase]
		public void ReturnsAggregateValueFromList()
		{
			List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
			Assert.AreEqual(15, _exercise.Aggregate(list));
		}

		/// <summary>
		/// Expects a response the largest value from a list
		/// </summary>
		[TestCase]
		public void ReturnsLargestValueFromList()
		{
			List<int> list = new List<int>() { 2, 5, 15, 0, 3 };
			Assert.AreEqual(15, _exercise.GetLargestValue(list));
		}
	}
}
