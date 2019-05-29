using LearningExercises.Dictionary;
using NUnit.Framework;
using System.Collections.Generic;
using static LearningExercises.Dictionary.DictionaryExercise;

namespace LearningExercises.Tests.Dictionary
{
	[TestFixture]
	public class DictionaryExerciseTests
	{
		private static DictionaryExercise _exercise = new DictionaryExercise();

		/// <summary>
		/// Expects a value to be returned from the dictionary which matches the given key
		/// </summary>
		[TestCase]
		public void ReturnsValueByKey()
		{
			var dictionary = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 } };
			Assert.AreEqual(3, _exercise.FindItemByKey("three", dictionary));
			Assert.AreEqual(1, _exercise.FindItemByKey("one", dictionary));
		}

		/// <summary>
		/// Expects the sum of all values in the dictionary to be returned
		/// </summary>
		[TestCase]
		public void ReturnsSumOfValues()
		{
			var dictionary = new Dictionary<string, int>() { { "1", 1 }, { "2", 2 }, { "3", 3 }, { "4", 4 } };
			Assert.AreEqual(10, _exercise.SumValues(dictionary));
			dictionary = new Dictionary<string, int>() { { "1", 2 }, { "2", 3 }, { "3", 4 }, { "4", 5 } };
			Assert.AreEqual(14, _exercise.SumValues(dictionary));
		}

		/// <summary>
		/// Expects a list of KeyValue objects to be returned from the dictionary
		/// </summary>
		[TestCase]
		public void ReturnsListOfKeyValueObjects()
		{
			var dictionary = new Dictionary<string, int>() { { "1", 1 }, { "2", 2 }, { "3", 3 }, { "4", 4 } };
			var expected = new List<KeyValue> {
				new KeyValue { Key = "1", Value = 1 },
				new KeyValue { Key = "2", Value = 2 },
				new KeyValue { Key = "3", Value = 3 },
				new KeyValue { Key = "4", Value = 4 }
			};
			Assert.That(_exercise.GetKeyValuePairs(dictionary), Is.EquivalentTo(expected));
		}
	}
}
