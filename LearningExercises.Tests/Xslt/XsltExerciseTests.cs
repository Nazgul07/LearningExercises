using LearningExercises.Xslt;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LearningExercises.Tests.Xslt
{
	[TestFixture]
	public class XsltExerciseTests
	{
		private static XsltExercise _exercise = new XsltExercise();
		/// <summary>
		/// Expects a xslt transform to match expected output
		/// </summary>
		[TestCase]
		public void ReturnsTheFirstValueFromXml()
		{
			XmlDocument expected = new XmlDocument();
			expected.LoadXml(@"<discography>
								  <album title='Empire Burlesque' artist='Bob Dylan'>
									<released>1985</released>
								  </album>
								  <album title='Hide your heart' artist='Bonnie Tyler'>
									<released>1988</released>
								  </album>
								  <album title='Still got the blues' artist='Gary Moore'>
									<released>1990</released>
								  </album>
								</discography>");
			XmlDocument actual = _exercise.TransformXml(@"<catalog>
								  <cd>
									<title>Empire Burlesque</title>
									<artist>Bob Dylan</artist>
									<country>USA</country>
									<company>Columbia</company>
									<price>10.90</price>
									<year>1985</year>
								  </cd>
								  <cd>
									<title>Hide your heart</title>
									<artist>Bonnie Tyler</artist>
									<country>UK</country>
									<company>CBS Records</company>
									<price>9.90</price>
									<year>1988</year>
								  </cd>
								  <cd>
									<title>Still got the blues</title>
									<artist>Gary Moore</artist>
									<country>UK</country>
									<company>Virgin records</company>
									<price>10.20</price>
									<year>1990</year>
								  </cd>
								</catalog>");
			Assert.AreEqual(expected.OuterXml, actual.OuterXml);
		}
	}
}
