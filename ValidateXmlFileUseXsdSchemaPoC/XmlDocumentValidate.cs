using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public class XmlDocumentValidate : IXmlFileValidation
    {
        public bool Validate(string xml, string xsd)
        {
            var result = true;
            var xmlSchemaSet = new XmlSchemaSet();

            using (var xmlReader = XmlReader.Create(new StringReader(xsd)))
            {
                xmlSchemaSet.Add(null, xmlReader);
            }
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            xmlDocument.Schemas = xmlSchemaSet;
            xmlDocument.Validate((sender, e) =>
            {
                if (e.Severity == XmlSeverityType.Error || e.Severity == XmlSeverityType.Warning)
                {
                    result = false;
                }
            });
            return result;
        }
    }
}