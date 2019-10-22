using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public class RunValidate
    {
        private readonly IValidatorFactory factory;

        public RunValidate(IValidatorFactory factory)
        {
            this.factory = factory;
        }



        public IXmlFileValidation Validate(ValidateMode validateMode)
        {
            return factory.Validation(validateMode);
        }
    }
}