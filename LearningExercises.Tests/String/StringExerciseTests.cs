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
			Assert.AreEqual(new[] { 't', 'e', 's', 't' }, _exercise.GetCharacterArrayFromString("test"));
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
		/// Expects a list of all indices where a given substring occurs in another string
		/// </summary>
		[TestCase]
		public void ReturnsIndicesOfSubstringInString()
		{
			Assert.AreEqual(new int[] { 10, 26, 33 }, _exercise.GetIndicesOfSubstringInString("the brown dog is the best dog in dog heaven", "dog"));
		}

		/// <summary>
		/// Expects a string to be reversed
		/// </summary>
		[TestCase]
		public void ReturnsStringInReverse()
		{
			Assert.AreEqual("nworb si god eht", _exercise.ReverseString("the dog is brown"));
		}

		/// <summary>
		/// Expects a response of the count of vowel occurences in a string (aeiou)
		/// </summary>
		[TestCase]
		public void ReturnsCountOfVowels()
		{
			Assert.AreEqual(8, _exercise.CountVowels("The dog is A brown dOg with fur"));
		}

		/// <summary>
		/// Expects a response of the input string with the casing inverted
		/// </summary>
		[TestCase]
		public void ReturnsCaseInvertedString()
		{
			Assert.AreEqual("tHE DOG IS a BROWN DoG WITH FUR", _exercise.InvertCase("The dog is A brown dOg with fur"));
		}
	}
}
