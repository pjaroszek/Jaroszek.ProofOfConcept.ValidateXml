
namespace ValidateXmlFileUseXsdSchemaPoC
{
    using ValidateXmlFileUseXsdSchemaPoC.Interfaces;
    using ValidateXmlFileUseXsdSchemaPoC.Services;

    public class ValidatorFactory : IValidatorFactory
    {
        private readonly string xsd;

        public ValidatorFactory(string xsd)
        {
            this.xsd = xsd;
        }

        public IXmlFileValidation Validation(ValidateMode validateMode)
        {
            if (validateMode == ValidateMode.Saxon)
            {
                return new XmlDocumentValidateUseSaxon(xsd);
            }
            else
            {
                return new XmlDocumentValidate(xsd);
            }
        }
    }
}