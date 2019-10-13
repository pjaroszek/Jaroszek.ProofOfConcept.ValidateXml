using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public abstract class ValidatorConditionerFactory
    {
        public abstract IXmlFileValidation Create(string xsd, string xml);
    }
}