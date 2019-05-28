using LearningExercises.Xml;
using NUnit.Framework;
using System.Xml;

namespace LearningExercises.Tests.Xml
{
	[TestFixture]
	public class XmlExerciseTests
	{
		private static XmlExercise _exercise = new XmlExercise();
		private static XmlDocument _documentOneThruFive = new XmlDocument();
		private static XmlDocument _documentSixThruTen = new XmlDocument();

		[OneTimeSetUp]
		public void FixtureSetup()
		{
			_documentOneThruFive.LoadXml(@"<Root>
									<Values>
										<Value>1</Value>
										<Value>2</Value>
										<Value>3</Value>
										<Value>4</Value>
										<Value>5</Value>
									</Values>
								</Root>");
			_documentSixThruTen.LoadXml(@"<Root>
									<Values>
										<Value>6</Value>
										<Value>7</Value>
										<Value>8</Value>
										<Value>9</Value>
										<Value>10</Value>
									</Values>
								</Root>");
		}

		/// <summary>
		/// Expects a result of 1 by selecting the first Value node and returning the InnerText of that node converted to an integer
		/// </summary>
		[TestCase]
		public void ReturnsTheFirstValueFromXml()
		{
			Assert.AreEqual(1, _exercise.GetTheFirstValueFromXml(_documentOneThruFive));
		}

		/// <summary>
		/// Expects a result of 5 by selecting the last Value node and returning the InnerText of that node converted to an integer
		/// </summary>
		[TestCase]
		public void ReturnsTheLastValueFromXml()
		{
			Assert.AreEqual(5, _exercise.GetTheLastValueFromXml(_documentOneThruFive));
		}

		/// <summary>
		/// Expects a result of 15 by summing each Value node's InnerText converted to integers
		/// </summary>
		[TestCase]
		public void ReturnsTheSumOfValuesFromXml()
		{
			Assert.AreEqual(15, _exercise.GetSumOfValuesFromXml(_documentOneThruFive));
		}

		/// <summary>
		/// Expects a result of an xml string which equals the document defined in this class, given only partial document and a list of values
		/// </summary>
		[TestCase]
		public void ReturnsXmlFromListOfValues()
		{
			XmlDocument _partialDocument = new XmlDocument();
			_partialDocument.LoadXml(@"<Root><Values></Values></Root>");
			Assert.AreEqual(_documentOneThruFive.OuterXml, _exercise.AddValuesToDocument(_partialDocument, new[] { 1, 2, 3, 4, 5 }));
		}

		/// <summary>
		/// Expects a result of a document with all Value nodes from 2 documents combined into one document
		/// </summary>
		[TestCase]
		public void ReturnsDocumentWithCombinedValues()
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(@"<Root>
									<Values>
										<Value>1</Value>
										<Value>2</Value>
										<Value>3</Value>
										<Value>4</Value>
										<Value>5</Value>
										<Value>6</Value>
										<Value>7</Value>
										<Value>8</Value>
										<Value>9</Value>
										<Value>10</Value>
									</Values>
								</Root>");
			Assert.AreEqual(doc.OuterXml, _exercise.CombineValuesFromTwoDocuments(_documentOneThruFive.Clone() as XmlDocument, _documentSixThruTen.Clone() as XmlDocument));
		}
	}
}
