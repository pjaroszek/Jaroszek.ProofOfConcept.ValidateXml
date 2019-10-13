using System.Collections.Generic;
using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    public class ValidateConditioner
    {
        private readonly Dictionary<Actions, ValidatorConditionerFactory> _factories;

        public ValidateConditioner()
        {
            _factories = new Dictionary<Actions, ValidatorConditionerFactory>();
            //            foreach (Actions action in Enum.GetValues(typeof(Actions)))
            //            {
            //                var factory = (ValidatorConditionerFactory)Activator.CreateInstance(Type.GetType("Jaroszek.ProofOfConcept.ValidateXml" + Enum.GetName(typeof(Actions), action) + "Factory"));
            //                _factories.Add(action, factory);
            //            }
            _factories = new Dictionary<Actions, ValidatorConditionerFactory>
            {
                { Actions.XmlDocument, new XmlFactory() },
                { Actions.Saxon, new XmlSaxonFactory() }
            };
        }

        public IXmlFileValidation ExecuteValidation(Actions action, string xsd) => _factories[action].Create(xsd);
    }
}