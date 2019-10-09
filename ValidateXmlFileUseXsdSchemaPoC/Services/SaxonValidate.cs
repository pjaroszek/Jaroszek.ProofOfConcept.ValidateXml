using Saxon.Api;
using System;
using System.Collections;
using System.IO;
using System.Xml;
using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC.Services
{
    public sealed class SaxonValidate : IXmlFileValidation
    {
        public bool Validate(string xml, string xsd)
        {
            bool result = true;
            Saxon.Api.Processor proc = new Processor(true);
            SchemaManager schemaManager = proc.SchemaManager;
            schemaManager.Compile(XmlReader.Create(new StringReader(xsd)));
            SchemaValidator validator = schemaManager.NewSchemaValidator();
            validator.SetSource(XmlReader.Create(new StringReader(xml)));
            validator.ErrorList = new ArrayList();
            try
            {
                validator.Run();

            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}