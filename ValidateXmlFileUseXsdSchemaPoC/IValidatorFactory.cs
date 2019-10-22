using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public interface IValidatorFactory
    {
        IXmlFileValidation Validation(ValidateMode validateMode);
    }
}