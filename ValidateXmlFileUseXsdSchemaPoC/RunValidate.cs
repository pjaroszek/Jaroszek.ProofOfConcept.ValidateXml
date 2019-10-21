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



        public IXmlFileValidation Validate(string param)
        {
            return factory.Validation(param);
        }
    }
}