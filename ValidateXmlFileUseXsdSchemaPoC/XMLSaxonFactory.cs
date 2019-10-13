using ValidateXmlFileUseXsdSchemaPoC.Interfaces;
using ValidateXmlFileUseXsdSchemaPoC.Services;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public class XmlSaxonFactory : ValidatorConditionerFactory
    {
        public override IXmlFileValidation Create(string xsd) => new XmlDocumentValidateUseSaxon(xsd);
    }
}