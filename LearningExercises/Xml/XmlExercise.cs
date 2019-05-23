using System;
using System.Xml;

namespace LearningExercises.Xml
{
	/// <summary>
	/// Expecations are to use XPath and XmlElement methods to query/modify the XmlDocuments
	/// </summary>
	public class XmlExercise
	{
		/// <summary>
		/// Hint: Use XPath to get the first Value node, and convert the result contents to an int
		/// </summary>
		public int GetTheFirstValueFromXml(XmlDocument document)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Hint: Use XPath to get the last Value node, and convert the result contents to an int
		/// </summary>
		public int GetTheLastValueFromXml(XmlDocument document)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Hint: Use XPath to all of the Value nodes, and convert the result contents of each to an int and sum them
		/// </summary>
		public int GetSumOfValuesFromXml(XmlDocument document)
		{
			throw new NotImplementedException();
		}

		public string AddValuesToDocument(XmlDocument document, int[] values)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Hint: You'll likely have to use "ImportNode" to get this to work the right way, but there are also ways to cheat
		/// </summary>
		public string CombineValuesFromTwoDocuments(XmlDocument documentOne, XmlDocument documentTwo)
		{
			throw new NotImplementedException();
		}
	}
}
