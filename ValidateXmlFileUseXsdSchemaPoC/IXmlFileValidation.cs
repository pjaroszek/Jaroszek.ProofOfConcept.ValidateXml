namespace ValidateXmlFileUseXsdSchemaPoC
{
    public interface IXmlFileValidation
    {
        bool Validate(string xml, string xsd);
    }
}