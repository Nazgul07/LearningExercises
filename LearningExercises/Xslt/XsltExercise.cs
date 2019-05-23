using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace LearningExercises.Xslt
{
	public class XsltExercise
	{
		/// <summary>
		/*Expectation is to return a result of
		 *
		 * <discography>
			<album title='Empire Burlesque' artist='Bob Dylan'>
				<released>1985</released>
			</album>
				<album title='Hide your heart' artist='Bonnie Tyler'>
			<year>1988</released>
			</album>
				<album title='Still got the blues' artist='Gary Moore'>
			<released>1990</released>
			</album>
		</discography>
		 */
		public XmlDocument TransformXml(string xml)
		{
			return Transform(@"<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>
									<xsl:template match='/'>
								  
									</xsl:template>
							</xsl:stylesheet>", xml);
		}

		public static XmlDocument Transform(string xslInput, string inputXml)
		{
			using (StringWriter sw = new StringWriter())
			using (XmlReader xrt = XmlReader.Create(new StringReader(xslInput)))
			using (XmlReader xri = XmlReader.Create(new StringReader(inputXml)))
			using (XmlWriter xwo = XmlWriter.Create(sw))
			{
				XslCompiledTransform xslt = new XslCompiledTransform();
				xslt.Load(xrt);
				xslt.Transform(xri, xwo);
				var doc = new XmlDocument();
				doc.LoadXml(sw.ToString());
				return doc;
			}
		}
	}
}
