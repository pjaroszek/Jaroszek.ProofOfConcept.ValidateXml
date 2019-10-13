using ValidateXmlFileUseXsdSchemaPoC.Interfaces;
using ValidateXmlFileUseXsdSchemaPoC.Services;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public class XmlFactory : ValidatorConditionerFactory
    {
        public override IXmlFileValidation Create(string xsd) => new XmlDocumentValidate(xsd);

    }
}