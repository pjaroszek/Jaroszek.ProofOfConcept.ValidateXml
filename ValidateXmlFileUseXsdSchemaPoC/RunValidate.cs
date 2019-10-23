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



        public IXmlFileValidation Validate(string validateMode)
        {
            return factory.Validation(validateMode);
        }
    }
}