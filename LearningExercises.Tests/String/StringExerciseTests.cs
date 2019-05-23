using LearningExercises.String;
using NUnit.Framework;
using System.Xml;

namespace LearningExercises.Tests.String
{
    [TestFixture]
	public class StringExerciseTests
	{
        private static StringExercise _exercise = new StringExercise();

        /// <summary>
		/// Expects a result of a character array given a string
		/// </summary>
		[TestCase]
		public void ReturnsCharactersFromStringAsArray()
		{
			Assert.AreEqual(new [] {'t','e','s','t'}, _exercise.GetCharacterArrayFromString("test"));
		}

        /// <summary>
		/// Expects a substring to be returned from a string given a start and end index within that string
		/// </summary>
		[TestCase]
		public void ReturnsSubstringFromString()
		{
			Assert.AreEqual("dog", _exercise.GetSubstring("the dog is brown", 4, 3));
		}

        /// <summary>
		/// Expects a list of all indexes where a given substring occurs in another string
		/// </summary>
		[TestCase]
		public void ReturnsIndexesOfSubstringInString()
		{
			Assert.AreEqual(new int[] {10, 26, 33}, _exercise.GetIndexesOfSubstringInString("the brown dog is the best dog in dog heaven", "dog"));
		}
    }
}